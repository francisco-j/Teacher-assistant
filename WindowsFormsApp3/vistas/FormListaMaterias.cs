using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp3.vistas;
using WindowsFormsApp3.clases_objeto;
using WindowsFormsApp3.componentes_visuales;
using System.Collections.Generic;

namespace WindowsFormsApp3
{
    public partial class frmMaterias : Form
    {
        public int idGrupo;
        private List<Materia> materias;
        public List<Alumno> alumnosGrupo;
        private int idMaestro;
        private int color = 0;
        private bool mostrandoTodosDias;

    #region constructor

        /// <summary> ventana que muestra la lista de materias del grupo indicado </summary>
        public frmMaterias(int idGrupo, int idMaestro)
        {
            InitializeComponent();

            this.idMaestro = idMaestro;
            this.idGrupo = idGrupo;
            this.Text = dbConection.getGrupo( idGrupo ).ToString();
            lblGrupo.Text += this.Text;

            cargarMaterias();
            cargarAlumnos();
            mostrandoTodosDias = false;
            cargarAsistencias();

            /*string[] alumnosForPrediccion = new string[alumnosGrupo.Count];
            for (short i = 0; i < alumnosGrupo.Count; i++ )
            {
                Alumno alum = alumnosGrupo[i] as Alumno;
                alumnosForPrediccion[ i ] = alum.getNombres() + " " + alum.getPaterno() + " " + alum.getMaterno();
            }
            txbBusqueda.AutoCompleteCustomSource.AddRange(alumnosForPrediccion);
            */

            this.Show();
        }

        #endregion

    #region ScrollEvents

        /// <summary>/// Cuando se mueva el panel de asistencia desplaza también el de fechas en caso de ser horizontal y el de nombres en caso de ser verical/// </summary>
        private void flPanelAsistencias_Scroll(object sender, ScrollEventArgs e)
        {
            flPanelFechas.HorizontalScroll.Value = flPanelAsistencias.HorizontalScroll.Value;
            flPanelAlumnos.VerticalScroll.Value = flPanelAsistencias.VerticalScroll.Value;
        }

        /*Aunque este método hace exactamene lo mismo que el de arriba se tiene que dejar por separado porque este se asigna desde código y el otro desde el diseñador
         y si se tratan de hacer los dos por código manda un error al tratar de asignarle un método que no recibe los parámetros adecuados*/
         /// <summary> Evento que desplaza verticalmente la lista de alumnos cuando se desplaza el panel de asistencias con el Scroll del mouse</summary>
        private void flPanelAsistencias_MouseScroll(object sender, MouseEventArgs e)
        {
            flPanelFechas.HorizontalScroll.Value = flPanelAsistencias.HorizontalScroll.Value;
            flPanelAlumnos.VerticalScroll.Value = flPanelAsistencias.VerticalScroll.Value;
        }

        //Este solamente necesita el evento de scroll del mouse porque la barra de scroll del panel de alumnos está siempre oculta al usuario
        /// <summary>Cuando se realiza scroll con el Scroll del mouse en el panel de alumnos también se desplaza verticalmente el panel de asistencias</summary>
        private void FlPanelAlumnos_MouseWheel(object sender, MouseEventArgs e)
        {
            flPanelAsistencias.VerticalScroll.Value = flPanelAlumnos.VerticalScroll.Value;
        }

        /// <summary>Desplaza horizontalmente el panel de asistencias cuando se hace scroll con el scroll del mouse sobre el panel de fechas</summary>
        private void FlPanelFechas_MouseWheel(object sender, MouseEventArgs e)
        {
            flPanelAsistencias.HorizontalScroll.Value = flPanelFechas.HorizontalScroll.Value;
        }

        #endregion

    #region otros eventos

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Program.returnToListaGrupos();
            this.Dispose();
        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            if( materias.Count <= 10 )
            {
                FormAgregarMateria nuevaMateria = new FormAgregarMateria(idGrupo);
                nuevaMateria.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Sólo se pueden agregar 10 materias por grupo", "Error al agregar materia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormListaG_FormClosed(object sender, FormClosedEventArgs e)
        {
            // cierra la aplicacion completa
            Application.Exit(); 
        }

        private void txbBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sólo acepta letras o dígitos, borrar, enter o espacios
            if (!Char.IsLetter(e.KeyChar) && !(e.KeyChar == 8 || e.KeyChar == 32 || e.KeyChar == 13))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 13)
            {
                btnBuscar.PerformClick();
            }
        }

        /// <summary> Muestra un ventana para agregar un alumno a la BD y a los componentes visuales</summary>
        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            if( alumnosGrupo.Count <= 60 )
            {
                FormAgregarAlumno alumnoNuevo = new FormAgregarAlumno(idGrupo);
                alumnoNuevo.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Sólo se pueden agregar 60 alumnos por grupo", "Error al agregar alumno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary> Muestra un ventana busqueda indicada </summary>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if( txbBusqueda.Text == "Nombre del alumno" )
                new FormResultadoBusqueda("", idMaestro);
            else
                new FormResultadoBusqueda(txbBusqueda.Text.Trim(), idMaestro);
        }

        /// <summary>Obtiene el día seleccionado del calendario cuando se quiere agregar un nuevo día</summary>
        private void monthCalendarSelected(object sender, DateRangeEventArgs e)
        {
            MonthCalendar fecha = (MonthCalendar)sender;

            DateTime dia = fecha.SelectionStart;

            if (dbConection.agregarDiaClase(dia, idGrupo))
                actualizarAssitencia(dia);
            else
                MessageBox.Show("El día que tratas de agregar ya está contemplado en las asistencias", "Día ya registrado", MessageBoxButtons.OK, MessageBoxIcon.Error);

            fecha.Hide();

            //int desplazamientoScroll = flPanelAsistencias.HorizontalScroll.Maximum;
            //flPanelAsistencias.HorizontalScroll.Value = desplazamientoScroll;
        }

        /// <summary>Cuando pierde el foco ocultará el calendario de agregar día</summary>
        private void monthCalendar_Leave(object sender, EventArgs e)
        {
            (sender as MonthCalendar).Hide();
        }

        /// <summary>Muestra un calendario para que el usuario pueda seleccionar una fecha y lo agregue a los días de asistencia</summary>
        private void btnAddDia_Click(object sender, EventArgs e)
        {
            MonthCalendar fecha = new MonthCalendar();
            this.Controls.Add(fecha);

            //fecha.Location = new Point(567, 57);
            fecha.Location = new Point(770, 365);

            fecha.Name = "mtcCalendario";
            fecha.Size = new Size(200, 20);
            fecha.TabIndex = 2;
            fecha.BringToFront();
            fecha.TodayDate = DateTime.Today;
            fecha.Focus();

            fecha.DateSelected += monthCalendarSelected;
            fecha.Leave += monthCalendar_Leave;
        }

        /// <summary>Muestra un formulario de confirmación para eliminar el alumno de la base de datos y de los componentes visuales</summary>
        private void borrarAlumno_Click(object sender, EventArgs e)
        {
            Alumno alumno = dbConection.getAlumno(Convert.ToInt32((sender as MenuItem).Name));
            FormBorrarAlumno formBorrarAlum = new FormBorrarAlumno(alumno, true);

            if( formBorrarAlum.ShowDialog(this) == DialogResult.OK )
            {
                flPanelAlumnos.Controls.RemoveByKey((sender as MenuItem).Name);

                flPanelAsistencias.Controls.RemoveByKey((sender as MenuItem).Name);
            }
        }

        /// <summary>Muestra un formulario para que se pueda cambiar el nombre y lo actualice en la base de datos y en la etiqueta de nombre</summary>
        private void editarAlumno_Click(object sender, EventArgs e)
        {
            int idAlumno = Convert.ToInt32((sender as MenuItem).Name);

            Alumno alumno = dbConection.getAlumno(idAlumno);
            FormBorrarAlumno formEditarAlum = new FormBorrarAlumno(alumno, false);

            if (formEditarAlum.ShowDialog(this) == DialogResult.OK)
            {
                Alumno alumnoEditado = dbConection.getAlumno(idAlumno);
                string nameAlumno = alumnoEditado.nombreCompletoPA();
                if (nameAlumno.Length > 25)
                {
                    ToolTip message = new ToolTip();
                    message.SetToolTip(((Label)(flPanelAlumnos.Controls.Find(idAlumno.ToString(), false)[0])), alumno.nombreCompletoPA());
                    nameAlumno = nameAlumno.Substring(0, 23) + "...";
                }
                ( (Label)( flPanelAlumnos.Controls.Find( idAlumno.ToString(), false ) [0] ) ).Text = nameAlumno;
            }
        }

        /// <summary>Cuando el mouse entra a alguno de los DateButtons cambiará el fondo del nombre y la fecha que corresponden de la asistencia</summary>
        public void asistenciaSelected(string idAlumno, string fecha)
        {
            (flPanelAlumnos.Controls.Find(idAlumno, false)[0] as Label).BackColor = Color.Silver;
            (flPanelFechas.Controls.Find(fecha, false)[0] as Label).BackColor = Color.Silver;
        }

        /// <summary>Cuando el puntero salga de algún DateButton regresará a su color ordinario el nombre y la fecha de la asistencia correspondiente</summary>
        public void asistenciaLeaveSelected(string idAlumno, string fecha)
        {
            (flPanelAlumnos.Controls.Find(idAlumno, false)[0] as Label).BackColor = Color.WhiteSmoke;
            (flPanelFechas.Controls.Find(fecha, false)[0] as Label).BackColor = Color.WhiteSmoke;
        }

        /// <summary>Elimina la fecha seleccionada de la base de datos y de todos los controles de asistencias de cada estudiante</summary>
        public void borrarFecha_Click( object sender, EventArgs e )
        {
            string fechaEliminar = (sender as MenuItem).Name;
            if (MessageBox.Show("¿Estás seguro que deseas eliminar la fecha " + fechaEliminar + " ?", "Borrar fecha", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //Se elimina del panel de fechas el dateLabel
                flPanelFechas.Controls.RemoveByKey(fechaEliminar);

                //Si está el label de control se debe quitar primero y luego volver a agregarse
                bool contieneLabel = flPanelFechas.Controls.Count - 1 <= 10;

                quitarLabelControl();

                System.Collections.IEnumerator diasAlumnos = flPanelAsistencias.Controls.GetEnumerator();

                while (diasAlumnos.MoveNext())
                {
                    ((FlowLayoutPanel)diasAlumnos.Current).Controls.RemoveByKey(fechaEliminar);
                    ((FlowLayoutPanel)diasAlumnos.Current).Size = ((FlowLayoutPanel)diasAlumnos.Current).PreferredSize;
                }

                if (contieneLabel)
                    agregarLabelControl();

                //Acomodar el string de la fecha en el formato adecuado para la base de datos
                string[] diaMesAnio = fechaEliminar.Split('/');
                fechaEliminar = diaMesAnio[1] + '/' + diaMesAnio[0] + '/' + diaMesAnio[2];

                dbConection.borrarDiaClase(fechaEliminar, this.idGrupo, alumnosGrupo);
            }

        }

#endregion

    #region metodos

        /// <summary>/// Usado para recibir de FormAgregarAlumno la información del alumno agregado</summary>
        public void recibirAlumno(Alumno nuevo)
        {
            lblInfoAlumnos.Dispose();
            lblArrowAlumno.Dispose();
            //agregar alumno al array
            alumnosGrupo.Add(nuevo);

            //hacer el label
            Label nombre = PersonalizacionComponentes.hacerLabelAlumno(nuevo); 

            //agregar el menú contextual
            MenuItem[] menu = {
                new MenuItem("Editar", editarAlumno_Click),
                new MenuItem("Borrar", borrarAlumno_Click)
            };
            menu[0].Name = nuevo.getId() + "";
            menu[1].Name = nuevo.getId() + "";

            nombre.ContextMenu = new ContextMenu(menu);

            flPanelAlumnos.Controls.Add(nombre);

            //Para evitar que desacomode los días nuevos para este nuevo alumno
            System.Collections.IEnumerator fechas = flPanelFechas.Controls.GetEnumerator();
            List<DiaClase> daysNewAlum = new List<DiaClase>();

            while (fechas.MoveNext())
            {
                string[] actualDay = ((tiltLabel)fechas.Current).Text.Split('/');

                daysNewAlum.Add( new DiaClase( new DateTime( Convert.ToInt32(actualDay[2]), Convert.ToInt32(actualDay[1]), Convert.ToInt32(actualDay[0]) ), nuevo.getId() ) );
            }

            //Asistencias
            //DiaClase[] diasClase = dbConection.getDiasClase(idGrupo);
            FlowLayoutPanel asistencias = PersonalizacionComponentes.hacerPanelAsistencias(nuevo.getId(), daysNewAlum.ToArray());
            asistencias.Name = nuevo.getId().ToString();

            //Quitar el label de control si es que está
            quitarLabelControl();

            flPanelAsistencias.Controls.Add(asistencias);

            Console.WriteLine(flPanelFechas.Controls.Count + " dias ");
            if (flPanelFechas.Controls.Count <= 10)
                agregarLabelControl();
        }

        /// <summary>Usado para recibir toda la información (incluido el id) de la materia nueva que se acaba de registrar</summary>
        public void recibirMateria( Materia newMateria )
        {
            lblArrowMateria.Dispose();
            lblInfoMaterias.Dispose();
            materias.Add(newMateria);
            flPanelMaterias.Controls.Add(PersonalizacionComponentes.hacerBotonMateria(newMateria, color));
            color++;
        }

        /// <summary>Actualizará el botón de la materia correspondiente y el elemento en la lista de materias que se haya cambiado su nombre</summary>
        public void modificacionMateria( string nombreNuevo, int id, string nombreAnterior )
        {
            (flPanelMaterias.Controls.Find(id.ToString(), false)[0] as Button).Text = nombreNuevo;
            int indice = 0;
            for (int i = 0; i < materias.Count; i++)
            {
                if (materias[i].getId() == id)
                {
                    indice = i;
                    break;
                }
            }
            materias[indice] = new Materia(id, nombreNuevo, idGrupo);
        }

        /// <summary>Eliminará el botón correspondiente y el elemento de la lista que coincida con el id de la materia recibidad</summary>
        public void eliminarMateria( int idEliminar )
        {
            flPanelMaterias.Controls.RemoveByKey( idEliminar.ToString() );
            int indice = 0;
            for (int i = 0; i < materias.Count; i++)
            {
                if (materias[i].getId() == idEliminar )
                {
                    indice = i;
                    break;
                }
            }
            materias.RemoveAt(indice);
        }

        ///<sumary> limpia el contenedor y carga todas las materias como botones nuevos </sumary>
        public void cargarMaterias()
        {
            materias = dbConection.materiasAsociadasCon(idGrupo);
            
            if( materias.Count != 0 )
            {
                lblInfoMaterias.Dispose();
                lblArrowMateria.Dispose();
                color = 0;

                foreach (Materia materia in materias)
                {
                    Button boton = PersonalizacionComponentes.hacerBotonMateria(materia, color);
                    flPanelMaterias.Controls.Add(boton);
                
                    color++;
                }
            }
        }

        /// <summary> Obtiene de BD todos los alumnos y los muestra en la lista de asistencia </summary>
        private void cargarAlumnos()
        {
            alumnosGrupo = dbConection.alumnosGrupo( idGrupo );

            if( alumnosGrupo.Count != 0 )
            {
                lblInfoAlumnos.Dispose();
                lblArrowAlumno.Dispose();
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

            flPanelAlumnos.MouseWheel += FlPanelAlumnos_MouseWheel;
        }

        /// <summary> llena la lista de asistencias </summary>
        private void cargarAsistencias()
        {
            DiaClase[] diasClase = dbConection.getDiasClase(idGrupo, mostrandoTodosDias);
            
            if( diasClase.Length != 0 )
            {
                flPanelAsistencias.Controls.Clear();
                flPanelFechas.Controls.Clear();
                lblArrowDia.Dispose();
                foreach (DiaClase diaClase in diasClase)
                {
                    tiltLabel labelFecha = new tiltLabel(diaClase);

                    MenuItem[] menu = {
                        new MenuItem("Borrar", borrarFecha_Click)
                    };
                    menu[0].Name = diaClase.dia.ToString("dd'/'MM'/'yy");

                    labelFecha.ContextMenu = new ContextMenu(menu);
                    flPanelFechas.Controls.Add( labelFecha );
                }
            
                foreach (Alumno alumno in alumnosGrupo)
                {
                    FlowLayoutPanel asistencias = PersonalizacionComponentes.hacerPanelAsistencias(alumno.getId(), diasClase);
                    asistencias.Name = alumno.getId().ToString();
                    flPanelAsistencias.Controls.Add(asistencias);
                }
                /*Cuando el número de días no es diez no aparece la barra ed scroll horizontal por lo que hay que hacer la validación y 
                 en este caso agregar un label con el tamaño de un scroll y que no desalinea los nombres con los días de asistencia */
                if (diasClase.Length <= 10)
                {
                    agregarLabelControl();
                }
            }

            //Evento de Scroll con el scroll del mouse
            flPanelAsistencias.MouseWheel += flPanelAsistencias_MouseScroll;
            flPanelFechas.MouseWheel += FlPanelFechas_MouseWheel;
        }

        /// <summary> Cuando se agrega un nuevo día para el grupo actual agrega una columna de DateButtons por cada alumno </summary>
        private void actualizarAssitencia(DateTime dia)
        {
            lblInfoDias.Dispose();
            lblArrowDia.Dispose();
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

            quitarLabelControl();
            //A cada uno de los paneles le agrega el nuevo día y le cambia el tamaño para que sea visible
            while (alumnosPanels.MoveNext())
            {
                ((FlowLayoutPanel)alumnosPanels.Current).Controls.Add(new DateButton(diaNuevo, true));
                ((FlowLayoutPanel)alumnosPanels.Current).Size = ((FlowLayoutPanel)alumnosPanels.Current).PreferredSize;
            }

            if (flPanelFechas.Controls.Count <= 10)
                agregarLabelControl();
        }

        private bool quitarLabelControl()
        {
            if (flPanelAsistencias.Controls.ContainsKey("labelScrollSustituto"))
            {
                flPanelAsistencias.Controls.RemoveByKey("labelScrollSustituto");
                return true;
            }
            return false;
        }
        
        private void agregarLabelControl()
        {
            Label lbl = new Label();
            lbl.Name = "labelScrollSustituto";
            lbl.Size = new Size(330, 15);
            lbl.BackColor = Color.WhiteSmoke;
            flPanelAsistencias.Controls.Add(lbl);
        }

        #endregion

        private void txbBusqueda_Click(object sender, EventArgs e)
        {
            if( txbBusqueda.ReadOnly )
            {
                txbBusqueda.Text = "";
                txbBusqueda.ReadOnly = false;
            }
        }

        private void btnVerTodosDias_Click(object sender, EventArgs e)
        {
            mostrandoTodosDias = !mostrandoTodosDias;
            cargarAsistencias();
            (sender as Button).Text = mostrandoTodosDias ? "Ver últimos 5 días de asistencia" : "Ver todos los días de asistencia";
        }
    }
}