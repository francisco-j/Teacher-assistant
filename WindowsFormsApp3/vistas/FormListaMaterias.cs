﻿using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp3.vistas;
using WindowsFormsApp3.clases_objeto;
using WindowsFormsApp3.componentes_visuales;

namespace WindowsFormsApp3
{
    public partial class FormListaMaterias : Form
    {
        private int idGrupo;
        private Materia[] materias;
        private Alumno[] alumnosGrupo;
        private int idMaestro;

        //Recibe un alumno de FormAgregarAlumno cuando se agregue un alumno desde ese formulario
        private Alumno nuevoAlumno;

#region constructor

        /// <summary> ventana que muestra la lista de materias del grupo indicado </summary>
        public FormListaMaterias(int idGrupo, int idMaestro)
        {
            InitializeComponent();

            this.idMaestro = idMaestro;
            this.idGrupo = idGrupo;
            this.Text = dbConection.getGrupo( idGrupo ).ToString();
            lblGrupo.Text += this.Text;

            cargarMaterias();
            cargarAlumnos();
            cargarAsistencias();


            this.Show();
        }

        #endregion
        
        #region eventos

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Program.returnToListaGrupos();
            this.Dispose();
        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            FormAgregarMateria nuevaMateria = new FormAgregarMateria(idGrupo);

            if( nuevaMateria.ShowDialog(this) == DialogResult.OK)
                cargarMaterias();
        }

        private void FormListaG_FormClosed(object sender, FormClosedEventArgs e)
        {
            // cierra la aplicacion completa
            Application.Exit(); 
        }

        private void txbBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnBuscar.PerformClick();
        }

        /// <summary> Muestra un ventana para agregar un alumno a la BD y a los componentes visuales</summary>
        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            FormAgregarAlumno alumnoNuevo = new FormAgregarAlumno(idGrupo);

            if( alumnoNuevo.ShowDialog(this) == DialogResult.OK)
            {
                nuevoAlumno = dbConection.getAlumno(nuevoAlumno.getNombres(), nuevoAlumno.getPaterno(), nuevoAlumno.getMaterno(), nuevoAlumno.getGupo());

                Label nombre = new Label();
                nombre.AutoSize = true;
                nombre.Font = new Font("Microsoft Sans Serif", 16);
                nombre.Text = nuevoAlumno.nombreCompletoPA();
                nombre.Name = nuevoAlumno.getId() + "";

                //Se le agrega el menú contextual al nuevo label que mstrará el nombre del alumno
                MenuItem[] menu = {
                    new MenuItem("Editar", editarAlumno_Click),
                    new MenuItem("Borrar", borrarAlumno_Click)
                };
                menu[0].Name = nuevoAlumno.getId() + "";
                menu[1].Name = nuevoAlumno.getId() + "";

                nombre.ContextMenu = new ContextMenu( menu );

                flPanelAlumnos.Controls.Add(nombre);
                flPanelAlumnos.Size = flPanelAlumnos.PreferredSize;

                //Asistencias
                DiaClase[] diasClase = dbConection.getDiasClase(idGrupo);
                FlowLayoutPanel asistencias = PersonalizacionComponentes.hacerPanelAsistencias(nuevoAlumno.getId(), diasClase);
                asistencias.Name = nuevoAlumno.getId().ToString();
                flPanelAsistencias.Controls.Add(asistencias);
                flPanelAsistencias.Size = flPanelAsistencias.PreferredSize;
            }
        }

        /// <summary> Muestra un ventana busqueda indicada </summary>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            new FormResultadoBusqueda(txbBusqueda.Text, idMaestro);
        }

        /// <summary>
        /// Obtiene el día seleccionado del calendario cuando se quiere agregar un nuevo día
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void monthCalendarSelected(object sender, DateRangeEventArgs e)
        {
            MonthCalendar fecha = (MonthCalendar)sender;

            DateTime dia = fecha.SelectionStart;

            if (!dbConection.dayExists(dia, idGrupo))
            {
                dbConection.agregarDiaClase(new DiaClase(dia, idGrupo));
                actualizarAssitencia(dia);
            }
            else
                MessageBox.Show("El día que tratas de agregar ya está contemplado en las asistencias", "Día ya registrado", MessageBoxButtons.OK, MessageBoxIcon.Error);

            fecha.Hide();
        }

        /// <summary>
        /// Cuando pierde el foco ocultará el calendario de agregar día
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void monthCalendar_Leave(object sender, EventArgs e)
        {
            (sender as MonthCalendar).Hide();
        }

        /// <summary>
        /// Muestra un calendario para que el usuario pueda seleccionar una fecha y lo agregue a los días de asistencia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddDia_Click(object sender, EventArgs e)
        {
            MonthCalendar fecha = new MonthCalendar();
            this.Controls.Add(fecha);

            fecha.Location = new Point(567, 57);
            fecha.Name = "mtcCalendario";
            fecha.Size = new Size(200, 20);
            fecha.TabIndex = 2;
            fecha.BringToFront();
            fecha.TodayDate = DateTime.Today;
            fecha.Focus();

            fecha.DateSelected += monthCalendarSelected;
            fecha.Leave += monthCalendar_Leave;
        }

        /// <summary>
        /// Muestra un formulario de confirmación para eliminar el alumno de la base de datos y de los componentes visuales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void borrarAlumno_Click(object sender, EventArgs e)
        {
            Alumno alumno = dbConection.getAlumno(Convert.ToInt32((sender as MenuItem).Name));
            FormBorrarAlumno formBorrarAlum = new FormBorrarAlumno(alumno, true);

            if (formBorrarAlum.ShowDialog(this) == DialogResult.OK)
            {
                flPanelAlumnos.Controls.RemoveByKey((sender as MenuItem).Name);

                flPanelAsistencias.Controls.RemoveByKey((sender as MenuItem).Name);
            }
        }

        /// <summary>
        /// Muestra un formulario para que se pueda cambiar el nombre y lo actualice en la base de datos y en la etiqueta de nombre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editarAlumno_Click(object sender, EventArgs e)
        {
            Alumno alumno = dbConection.getAlumno(Convert.ToInt32((sender as MenuItem).Name));
            FormBorrarAlumno formEditarAlum = new FormBorrarAlumno(alumno, false);

            if (formEditarAlum.ShowDialog(this) == DialogResult.OK)
            {
                Alumno alumnoEditado = dbConection.getAlumno(Convert.ToInt32((sender as MenuItem).Name));

                ((Label)(flPanelAlumnos.Controls.Find(alumnoEditado.getId().ToString(), false)[0])).Text = alumnoEditado.nombreCompletoPA();
            }
        }

        /// <summary>
        /// Cuando el mouse entra a alguno de los DateButtons cambiará el fondo del nombre y la fecha que corresponden de la asistencia
        /// </summary>
        /// <param name="idAlumno"></param>
        /// <param name="fecha"></param>
        public void asistenciaSelected(string idAlumno, string fecha)
        {
            (flPanelAlumnos.Controls.Find(idAlumno, false)[0] as Label).BackColor = Color.Silver;
            (flPanelFechas.Controls.Find(fecha, false)[0] as Label).BackColor = Color.Silver;
        }

        /// <summary>
        /// Cuando el puntero salga de algún DateButton regresará a su color ordinario el nombre y la fecha de la asistencia correspondiente
        /// </summary>
        /// <param name="idAlumno"></param>
        /// <param name="fecha"></param>
        public void asistenciaLeaveSelected(string idAlumno, string fecha)
        {
            (flPanelAlumnos.Controls.Find(idAlumno, false)[0] as Label).BackColor = Color.WhiteSmoke;
            (flPanelFechas.Controls.Find(fecha, false)[0] as Label).BackColor = Color.WhiteSmoke;
        }

        public void borrarFecha_Click( object sender, EventArgs e )
        {
            string fechaEliminar = (sender as MenuItem).Name;
            if ( MessageBox.Show("¿Estás seguro que deseas eliminar la fecha " + fechaEliminar + " ?", "Borrar fecha", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes )
            {
                //Se elimina del panel de fechas el dateLabel
                flPanelFechas.Controls.RemoveByKey(fechaEliminar);

                System.Collections.IEnumerator diasAlumnos = flPanelAsistencias.Controls.GetEnumerator();

                while( diasAlumnos.MoveNext() )
                {
                    ((FlowLayoutPanel)diasAlumnos.Current).Controls.RemoveByKey(fechaEliminar);
                }

                //Acomodar el string de la fecha en el formato adecuado para la base de datos
                string[] diaMesAnio = fechaEliminar.Split('/');
                fechaEliminar = diaMesAnio[1] + '/' + diaMesAnio[0] + '/' + diaMesAnio[2];

                dbConection.borrarDiaClase(fechaEliminar, this.idGrupo);
            }

        }

        #endregion

        #region metodos

        public int getIdGrupo()
        {
            return idGrupo;
        }

        /// <summary>
        /// Usado para recibir de FormAgregarAlumno la información del alumno agregado
        /// </summary>
        /// <param name="nuevo"></param>
        public void recibirNombreAlumno(Alumno nuevo)
        {
            nuevoAlumno = nuevo;
        }

        ///<sumary> limpia el contenedor y carga todas las materias como botones nuevos </sumary>
        public void cargarMaterias()
        {
            materias = dbConection.materiasAsociadasCon(idGrupo);

            flPanelMaterias.Controls.Clear();
            int color = 0;

            foreach (Materia materia in materias)
            {
                Button boton = PersonalizacionComponentes.hacerBotonMateria(materia, color);
                flPanelMaterias.Controls.Add(boton);
                
                color++;
            }
        }

        /// <summary> Obtiene de BD todos los alumnos y los muestra en la lista de asistencia </summary>
        private void cargarAlumnos()
        {
            alumnosGrupo = dbConection.alumnosGrupo( idGrupo );

            PersonalizacionComponentes.llenarPanelAlunos(flPanelAlumnos, alumnosGrupo);

            System.Collections.IEnumerator labelsAlumnos = flPanelAlumnos.Controls.GetEnumerator();

            while( labelsAlumnos.MoveNext() )
            {
                string idAlumno = ((Label)labelsAlumnos.Current).Name;

                MenuItem[] menu = {
                    new MenuItem("Editar", editarAlumno_Click),
                    new MenuItem("Borrar", borrarAlumno_Click)
                };
                menu[0].Name = idAlumno;
                menu[1].Name = idAlumno;

                ((Label)labelsAlumnos.Current).ContextMenu = new ContextMenu(menu);
            }
        }

        /// <summary> llena la lista de asistencias </summary>
        private void cargarAsistencias()
        {
            flPanelAsistencias.Controls.Clear();
            flPanelFechas.Controls.Clear();
            DiaClase[] diasClase = dbConection.getDiasClase(idGrupo);
            
            foreach (DiaClase dia in diasClase)
            {
                tiltLabel labelFecha = new tiltLabel(dia);

                MenuItem[] menu = {
                    new MenuItem("Borrar", borrarFecha_Click)
                };
                menu[0].Name = dia.dia.ToString("dd'/'MM'/'yy");

                labelFecha.ContextMenu = new ContextMenu(menu);
                flPanelFechas.Controls.Add( labelFecha );
            }
            flPanelFechas.Size = flPanelAsistencias.PreferredSize;
            
            foreach (Alumno alumno in alumnosGrupo)
            {
                FlowLayoutPanel asistencias = PersonalizacionComponentes.hacerPanelAsistencias(alumno.getId(), diasClase);
                asistencias.Name = alumno.getId().ToString();
                flPanelAsistencias.Controls.Add(asistencias);
            }
        }

        /// <summary>
        /// Cuando se agrega un nuevo día para el grupo actual agrega una columna de DateButtons por cada alumno 
        /// </summary>
        /// <param name="dia"></param>
        private void actualizarAssitencia(DateTime dia)
        {
            DiaClase diaNuevo = new DiaClase(dia, idGrupo);
            //Se sacan todos los paneles de asistencias de los alumnos
            System.Collections.IEnumerator alumnosPanels = flPanelAsistencias.Controls.GetEnumerator();

            //Se agrega al panel de fechas el nuevo día agregado
            tiltLabel labelFecha = new tiltLabel(diaNuevo);
            labelFecha.Name = diaNuevo.dia.ToString("dd'/'MM'/'yy");

            MenuItem[] menu = {
                    new MenuItem("Borrar", borrarFecha_Click)
                };
            menu[0].Name = dia.ToString("dd'/'MM'/'yy");

            labelFecha.ContextMenu = new ContextMenu(menu);

            flPanelFechas.Controls.Add(labelFecha);

            //A cada uno de los paneles le agrega el nuevo día y le cambia el tamaño para que sea visible
            while (alumnosPanels.MoveNext())
            {
                ((FlowLayoutPanel)alumnosPanels.Current).Controls.Add(new DateButton(diaNuevo, true));
                ((FlowLayoutPanel)alumnosPanels.Current).Size = ((FlowLayoutPanel)alumnosPanels.Current).PreferredSize;
            }
        }


        #endregion
    }
}