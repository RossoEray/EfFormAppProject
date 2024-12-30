using System;
using System.Linq;
using System.Windows.Forms;
using EfFormAppProject.Data;
using EfFormAppProject.Models;

namespace EfFormAppProject
{
    public partial class DersSecimi : Form
    {
        private readonly Student _student;

        public DersSecimi(Student student)
        {
            InitializeComponent();
            _student = student;
            lblOgrenciBilgi.Text = $"Seçilen Öğrenci: {_student.StudentName} {_student.StudentSurname}";
        }

        private void DersSecimi_Load(object sender, EventArgs e)
        {
            using (var context = new ObsDbContext())
            {
                var selectedLessonIds = context.StudentLessons
                    .Where(sl => sl.StudentId == _student.StudentId)
                    .Select(sl => sl.LessonId)
                    .ToList();

                var dersler = context.Lessons.Select(d => new
                {
                    d.LessonId,
                    d.LessonName,
                    IsSelected = selectedLessonIds.Contains(d.LessonId)
                }).ToList();

                dataGridViewDersler.DataSource = dersler;
                dataGridViewDersler.Columns["LessonId"].Visible = false;
                dataGridViewDersler.Columns["LessonName"].HeaderText = "Ders Adı";
                dataGridViewDersler.Columns["IsSelected"].Visible = false;
                dataGridViewDersler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                AddCheckBoxColumn();
                HighlightSelectedLessons();
            }
        }

        private void AddCheckBoxColumn()
        {
            var checkBoxColumn = new DataGridViewCheckBoxColumn
            {
                HeaderText = "Seç",
                Name = "CheckColumn"
            };
            dataGridViewDersler.Columns.Insert(0, checkBoxColumn);
        }

        private void HighlightSelectedLessons()
        {
            foreach (DataGridViewRow row in dataGridViewDersler.Rows)
            {
                bool isSelected = (bool)row.Cells["IsSelected"].Value;
                if (isSelected)
                {
                    row.Cells["CheckColumn"].Value = true;
                    row.Cells["CheckColumn"].ReadOnly = true;
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (var context = new ObsDbContext())
            {
                var selectedLessons = dataGridViewDersler.Rows.Cast<DataGridViewRow>()
                    .Where(row => Convert.ToBoolean(row.Cells["CheckColumn"].Value) == true &&
                                  !Convert.ToBoolean(row.Cells["IsSelected"].Value))
                    .Select(row => (int)row.Cells["LessonId"].Value)
                    .ToList();

                if (!selectedLessons.Any())
                {
                    MessageBox.Show("Lütfen yeni dersler seçiniz!");
                    return;
                }

                foreach (var lessonId in selectedLessons)
                {
                    var studentLesson = new StudentLesson
                    {
                        StudentId = _student.StudentId,
                        LessonId = lessonId
                    };
                    context.StudentLessons.Add(studentLesson);
                }

                context.SaveChanges();
                MessageBox.Show("Seçilen dersler başarıyla kaydedildi!");
                Close();
            }
        }
    }
}