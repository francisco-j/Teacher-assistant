using System;
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

        /// <summary> Muestra un ventana para agregar un alumno a la BD </summary>
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
        }

        /// <summary>  </summary>
        private void cargarAsistencias()
        {
            flPanelAsistencias.Controls.Clear();
            flPanelFechas.Controls.Clear();
            DiaClase[] diasClase = dbConection.getDiasClase(idGrupo);
            
            foreach (DiaClase dia in diasClase)
            {
                flPanelFechas.Controls.Add(new dateLabel(dia));
            }
            flPanelFechas.Size = flPanelAsistencias.PreferredSize;

            foreach (Alumno alumno in alumnosGrupo)
            {
                FlowLayoutPanel asistencias = PersonalizacionComponentes.hacerPanelAsistencias(alumno.getId(), diasClase);
                asistencias.Name = alumno.getId().ToString();
                flPanelAsistencias.Controls.Add(asistencias);
            }
        }

        private void actualizarAssitencia( DateTime dia )
        {
            DiaClase diaNuevo = new DiaClase(dia, idGrupo);
            //Se sacan todos los paneles de asistencias de los alumnos
            System.Collections.IEnumerator alumnosPanels = flPanelAsistencias.Controls.GetEnumerator();
            //Se agrega al panel de fechas el nuevo día agregado
            flPanelFechas.Controls.Add(new dateLabel(diaNuevo));

            //A cada uno de los paneles le agrega el nuevo día y le cambia el tamaño para que sea visible
            while( alumnosPanels.MoveNext() )
            {
                ((FlowLayoutPanel)alumnosPanels.Current).Controls.Add(new DateButton(diaNuevo, true, Properties.Resources.icoCheckMark24));
                ((FlowLayoutPanel)alumnosPanels.Current).Size = ((FlowLayoutPanel)alumnosPanels.Current).PreferredSize;
            }
        }


        #endregion
    }
}