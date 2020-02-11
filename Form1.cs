/*‘LAB # 4   
‘SEMESTER NAME Winter 2019
‘STUDENT’S FIRST NAME Marisa, LAST NAME Wade 
‘I fully understand the following statement. 
‘OU PLAGIARISM POLICY 
‘All members of the academic community at Oakland are expected to practice and uphold 
‘standards of academic integrity and honesty. An instructor is expected to inform and instruct 
‘students about the procedures and standards of research and documentation required of students 
‘in fulfilling course work. A student is expected to follow such instructions and be sure the rules 
‘and procedures are understood in order to avoid inadvertent misrepresentation of his work. 
‘Students must assume that individual (unaided) work on exams and lab reports and documentation 
‘of sources is expected unless the instructor specifically says that is not necessary. 
 
‘The following definitions are some examples of academic dishonesty:  
‘Plagiarizing from work of others. Plagiarism is using someone else's work or ideas without 
‘giving the other person credit; by doing this, a student is, in effect, claiming credit for 
‘someone else's thinking. Whether the student has read or heard the information he/she uses, 
‘the student must document the source of information. When dealing with written sources, 
‘a clear distinction would be made between quotations (which reproduce information from 
‘the source word-for-word within quotation marks) and paraphrases (which digest the 
‘source information and produce it in the student's own words). Both direct quotations and 
‘paraphrases must be documented. Just because a student rephrases, condenses or selects 
‘from another person's work, the ideas are still the other person's, and failure to give 
‘credit constitutes misrepresentation of the student's actual work and plagiarism of 
‘another's ideas. Naturally, buying a paper and handing it in as one's own work is 
‘plagiarism.  
‘Cheating on lab reports falsifying data or submitting data not based on student's own work. 
*/





using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Marisa_Wade
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int score = 0;
        int state = 1;
        int point = 0;
        

        private void btnRoll_Click(object sender, EventArgs e)
        {
            int x1, x2;
            Random rand = new Random();
            x1 = rand.Next(1, 7);
            x2 = rand.Next(1, 7);

            int totalnum;
            totalnum = x1 + x2;

            


            txtBox1.Text = x1.ToString();
            txtBox2.Text = x2.ToString();
            txtBoxTotal.Text = totalnum.ToString();
            txtBoxPoints.Text = point.ToString();

            

            //show the dices

            if (x1 == 1)
            {
                picBox1.Visible = true;
                picBox2.Visible = false;
                picBox3.Visible = false;
                picBox4.Visible = false;
                picBox5.Visible = false;
                picBox6.Visible = false;

            }

            if (x1 == 2)
            {
                picBox1.Visible = false;
                picBox2.Visible = true;
                picBox3.Visible = false;
                picBox4.Visible = false;
                picBox5.Visible = false;
                picBox6.Visible = false;

            }

            if (x1 == 3)
            {
                picBox1.Visible = false;
                picBox2.Visible = false;
                picBox3.Visible = true;
                picBox4.Visible = false;
                picBox5.Visible = false;
                picBox6.Visible = false;

            }

            if (x1 == 4)
            {
                picBox1.Visible = false;
                picBox2.Visible = false;
                picBox3.Visible = false;
                picBox4.Visible = true;
                picBox5.Visible = false;
                picBox6.Visible = false;

            }

            if (x1 == 5)
            {
                picBox1.Visible = false;
                picBox2.Visible = false;
                picBox3.Visible = false;
                picBox4.Visible = false;
                picBox5.Visible = true;
                picBox6.Visible = false;
            }

            if (x1 == 6)
            {
                picBox1.Visible = false;
                picBox2.Visible = false;
                picBox3.Visible = false;
                picBox4.Visible = false;
                picBox5.Visible = false;
                picBox6.Visible = true;
            }

            if (x2 == 1)
            {
                picBox7.Visible = true;
                picBox8.Visible = false;
                picBox9.Visible = false;
                picBox10.Visible = false;
                picBox11.Visible = false;
                picBox12.Visible = false;
            }

            if (x2 == 2)
            {
                picBox7.Visible = false;
                picBox8.Visible = true;
                picBox9.Visible = false;
                picBox10.Visible = false;
                picBox11.Visible = false;
                picBox12.Visible = false;
            }

            if (x2 == 3)
            {
                picBox7.Visible = false;
                picBox8.Visible = false;
                picBox9.Visible = true;
                picBox10.Visible = false;
                picBox11.Visible = false;
                picBox12.Visible = false;
            }

            if (x2 == 4)
            {
                picBox7.Visible = false;
                picBox8.Visible = false;
                picBox9.Visible = false;
                picBox10.Visible = true;
                picBox11.Visible = false;
                picBox12.Visible = false;
            }

            if (x2 == 5)
            {
                picBox7.Visible = false;
                picBox8.Visible = false;
                picBox9.Visible = false;
                picBox10.Visible = false;
                picBox11.Visible = true;
                picBox12.Visible = false;
            }

            if (x2 == 6)
            {
                picBox7.Visible = false;
                picBox8.Visible = false;
                picBox9.Visible = false;
                picBox10.Visible = false;
                picBox11.Visible = false;
                picBox12.Visible = true;
            }

            //compute the total num

            if (state == 1)
            {
                picBoxBlack.Visible = true;

                if (totalnum == 7 || totalnum == 11)
                {
                    lblResults.Text = "Winner!";
                    score++;
                    txtBoxScore.Text = score.ToString();
                    state = 1;
                    picBoxBlack.Visible = true;

                }
                else if (totalnum == 2 || totalnum == 3 || totalnum == 12)
                {
                    lblResults.Text = "Loser!";
                    score--;
                    txtBoxScore.Text = score.ToString();
                    state = 1;
                    picBoxBlack.Visible = true;
                }
                else
                {
                    lblResults.Text = "Roll again";
                    state = 2;
                    point = totalnum;
                    txtBoxScore.Text = score.ToString();
                    
                    if (point == 4)
                    {
                        picBox13.Visible = true;
                        picBox14.Visible = false;
                        picBox15.Visible = false;
                        picBox16.Visible = false;
                        picBox17.Visible = false;
                        picBox18.Visible = false;
                    }
                    if (point == 5)
                    {
                        picBox13.Visible = false;
                        picBox14.Visible = true;
                        picBox15.Visible = false;
                        picBox16.Visible = false;
                        picBox17.Visible = false;
                        picBox18.Visible = false;
                    }
                    if (point == 6)
                    {
                        picBox13.Visible = false;
                        picBox14.Visible = false;
                        picBox15.Visible = true;
                        picBox16.Visible = false;
                        picBox17.Visible = false;
                        picBox18.Visible = false;


                    }

                    if (point == 8)
                    {
                        picBox13.Visible = false;
                        picBox14.Visible = false;
                        picBox15.Visible = false;
                        picBox16.Visible = true;
                        picBox17.Visible = false;
                        picBox18.Visible = false;
                    }
                    if (point == 9)
                    {
                        picBox13.Visible = false;
                        picBox14.Visible = false;
                        picBox15.Visible = false;
                        picBox16.Visible = false;
                        picBox17.Visible = true;
                        picBox18.Visible = false;
                    }
                    if (point == 10)
                    {
                        picBox13.Visible = false;
                        picBox14.Visible = false;
                        picBox15.Visible = false;
                        picBox16.Visible = false;
                        picBox17.Visible = false;
                        picBox18.Visible = true;
                    }
                }

            }

            else if (state == 2)
            {
                if (totalnum == point)
                {
                    lblResults.Text = "Winner!";
                    state = 1;
                    score++;
                    txtBoxScore.Text = score.ToString();
                }
                else if (totalnum == 7)
                {
                    lblResults.Text = "Loser!";
                    state = 1;
                    score--;
                    txtBoxScore.Text = score.ToString();
                }
                else
                {
                    lblResults.Text = "Roll again!";
                    state = 2;
                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxPoints_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
        

