using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Memory;
using System.Text.Json;
using System.Text.Json.Serialization;
//using Newtonsoft.Json;

namespace Aufgabe_6
{
    public partial class Form1 : Form
    {

        string defaultPic = "iVBORw0KGgoAAAANSUhEUgAACAAAAAgAAQAAAACa3O6dAAAABGdBTUEAALGPC/xhBQAAACBjSFJNAAB6JgAAgIQAAPoAAACA6AAAdTAAAOpgAAA6mAAAF3CculE8AAAAAmJLR0QAAd2KE6QAAAAHdElNRQfmChkDJRiSsaRjAAAJEElEQVR42u3QMQEAAAwCIPuX1n8VBhFIn4sAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAgQIAAAQIECBAg4BpJ/neJdBB0dAAAACV0RVh0ZGF0ZTpjcmVhdGUAMjAyMi0xMC0yNVQwMzozNzoyNCswMDowMJlQ6z0AAAAldEVYdGRhdGU6bW9kaWZ5ADIwMjItMTAtMjVUMDM6Mzc6MjQrMDA6MDDoDVOBAAAAAElFTkSuQmCC";
        List<Userdata> users = new List<Userdata>();
        public Form1()
        {
            InitializeComponent();
        }

        private void update()
        {
            listBox1.Items.Clear();
            foreach (var user in users)
            {
                listBox1.Items.Add(user.userid);
            }
        }

        private string convert2string()
        {
            if (openFileDialog1.FileName == "")
            {
                return "";
            }
            else
            {
                byte[] imageArray = System.IO.File.ReadAllBytes(openFileDialog1.FileName);
                //string base64ImageRepresentation = Convert.ToBase64String(imageArray);
                return Convert.ToBase64String(imageArray);
            }
            
        }

        private Image convert2pic(string imagestring)
        {
            if (imagestring == null || imagestring == "")
            {
                return Image.FromStream(new MemoryStream(Convert.FromBase64String(defaultPic)));
                //Image img = Image.FromStream(new MemoryStream(Convert.FromBase64String(defaultPic)));
                //return img;
            }
            else
            {
                return Image.FromStream(new MemoryStream(Convert.FromBase64String(imagestring)));
                //Image img = Image.FromStream(new MemoryStream(Convert.FromBase64String(imagestring)));
                //return img;
            }
            
        }

        private void save()
        {
            StreamWriter writer = new StreamWriter("Daten.json");
            writer.Write(JsonSerializer.Serialize(users));
            writer.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            if (File.Exists("Daten.json") == false)
            {
                StreamWriter writer = new StreamWriter("Daten.json");

                writer.Write("[]");
                writer.Close();
                return;
            }


            try
            {
                StreamReader read = new StreamReader("Daten.json");
                var data = JsonSerializer.Deserialize<List<Userdata>>(read.ReadToEnd());
                if (data != null)
                {
                    users = data;
                }

                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Iwas lief falsch, alles gelöscht: " + ex.ToString());
            }

            update();

        }

        private string calcage(DateTime bday)
        {
            // Save today's date.
            var today = DateTime.Today;

            // Calculate the age.
            var age = today.Year - bday.Year;

            // Go back to the year in which the person was born in case of a leap year
            if (bday.Date > today.AddYears(-age)) age--;

            return age.ToString();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
        private void lastname_TextChanged(object sender, EventArgs e)
        {

        }
        private void street_TextChanged(object sender, EventArgs e)
        {

        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        private void mail_TextChanged(object sender, EventArgs e)
        {

        }
        private void city_TextChanged(object sender, EventArgs e)
        {

        }       
        private void data_name_TextChanged(object sender, EventArgs e)
        {
            
        } 
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            Userdata userfound = null;
            foreach (var user in users)
            {
                if (user.userid == data_name.Text)
                {
                    userfound = user;
                    break;
                }
            }
            

            if (userfound == null)
            {
                var userdata = new Userdata
                {

                    name = name.Text,
                    lastname = lastname.Text,
                    bday = dateTimePicker1.Value,
                    city = city.Text,
                    mail = mail.Text,
                    userid = data_name.Text,
                    pb = convert2string(),
                };

                users.Add(userdata);
            }
            else
            {
                if (data_name.Text == "")
                {
                    MessageBox.Show("Bitte Datensatz benennen");
                }
                else
                {
                    userfound.name = name.Text;
                    userfound.lastname = lastname.Text;
                    userfound.bday = dateTimePicker1.Value;
                    userfound.city = city.Text;
                    userfound.mail = mail.Text;
                    userfound.userid = data_name.Text;
                    userfound.pb= convert2string();
                }
                
            }

            save();
            update();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                name.Text = users[listBox1.SelectedIndex].name;
                lastname.Text = users[listBox1.SelectedIndex].lastname;
                dateTimePicker1.Value = users[listBox1.SelectedIndex].bday;
                city.Text = users[listBox1.SelectedIndex].city;
                mail.Text = users[listBox1.SelectedIndex].mail;
                data_name.Text = users[listBox1.SelectedIndex].userid;
                pictureBox1.Image = convert2pic(users[listBox1.SelectedIndex].pb);
                AgeLabel.Text = calcage(users[listBox1.SelectedIndex].bday);

            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
            pictureBox1.Image = convert2pic(convert2string());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        
        private void deletepb(object sender, EventArgs e)
        {
            pictureBox1.Image = convert2pic("");
            openFileDialog1.FileName = "";
            users[listBox1.SelectedIndex].pb = convert2string();
        }
    }
}