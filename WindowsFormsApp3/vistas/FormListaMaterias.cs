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

#region constructor

        /// <summary> ventana que muestra la lista de materias del grupo indicado </summary>
        public FormListaMaterias(int idGrupo)
        {
            InitializeComponent();

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
            nuevaMateria.ShowDialog(this);

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

            alumnoNuevo.ShowDialog();

            //Refresca la lista de alumnos
            cargarAlumnos();
            cargarAsistencias();
        }

        /// <summary> Muestra un ventana busqueda indicada </summary>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            new FormResultadoBusqueda(txbBusqueda.Text);
        }

        #endregion

        #region metodos

        public int getIdGrupo()
        {
            return idGrupo;
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
                flPanelFechas.Controls.Add(new tiltLabel(dia));
            }

            foreach (Alumno alumno in alumnosGrupo)
            {
                FlowLayoutPanel asistencias = PersonalizacionComponentes.hacerPanelAsistencias(alumno.getId(), diasClase);

                flPanelAsistencias.Controls.Add(asistencias);
            }
        }


        #endregion

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

            fecha.DateSelected += monthCalendarSelected;
        }

        private void monthCalendarSelected(object sender, DateRangeEventArgs e)
        {
            MonthCalendar fecha = (MonthCalendar)sender;

            DateTime dia = fecha.SelectionStart;

            dbConection.agregarDiaClase(new DiaClase(dia, idGrupo));
            
            fecha.Dispose();
        }
    }
}