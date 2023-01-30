using System.ComponentModel.DataAnnotations;

namespace LAB4
{
    public partial class Form1 : Form
    {
        Classroom classroom;
        List<string> nameAll = new List<string>();
        List<double> GPAAll = new List<double>();
        
        public Form1()
        {
            InitializeComponent();
            classroom = new Classroom("OOP");
        }

        private void textName1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBirth2_TextChanged(object sender, EventArgs e)
        {

        }
        private void Addbutton1_Click(object sender, EventArgs e)
        {
            string input_name = this.textName1.Text;
            string input_year = this.textBirth2.Text;
            string input_gPa = this.textGPA1.Text;
            int iYear = Int32.Parse(input_year);
            double GPPA = double.Parse(input_gPa);

           

            Person person = new Person(input_name, iYear,GPPA);
            this.classroom.addPerson2Class(person);
            //display total name
            this.AllnametextBox1.Text = this.classroom.showAllPersoninClass();
            //display total age
            this.AllnumtextBox2.Text = this.classroom.showAllAgePerson();
            



            GPAAll.Add(GPPA);
            GPAAll.Sort();




            //Show Max min 
            this.textGPAMaxBox3.Text = GPAAll.Last().ToString();
            this.textGPAminBox2.Text = GPAAll.First().ToString();
            //Show name Max Min
            this.textShownameMaxBox4.Text = this.textName1.Text.Last().ToString(); 
            this.textShownameMinBox5.Text = this.textName1.Text.First().ToString();



            //sum Gpa avg
            double cerrentgpa = double.Parse(this.textGPA1.Text);
            double Avggpa = (cerrentgpa + person.GetGPA())/5;
            this.textGPAavgBox1.Text = Avggpa.ToString(); 


            //show person name
            //this.AllnametextBox1.Text += person.GetName() + "\r\n";
            //sum all person age
            //int currentage = Int32.Parse(this.AllnumtextBox2.Text);
            //int newTotalAge = currentage + person.GetAge();
            //this.AllnumtextBox2.Text = newTotalAge.ToString();


        }

    }
}