using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;

namespace TextToSpeechConvertor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SpeechSynthesizer speechSynthesizerObj;
        private void speakbtn_Click(object sender, EventArgs e)
        {
            //Disposes the SpeechSynthesizer object  
            if (textbox.Text != "")
            {
                speechSynthesizerObj = new SpeechSynthesizer();
                //Asynchronously speaks the contents present in RichTextBox1   
                speechSynthesizerObj.SpeakAsync(textbox.Text);
                stopbtn.Enabled = true;
            }
        }

        private void stopbtn_Click(object sender, EventArgs e)
        {
            if (speechSynthesizerObj != null)
            {
                //Disposes the SpeechSynthesizer object   
                speechSynthesizerObj.Dispose();
                speakbtn.Enabled = true;
                stopbtn.Enabled = false;
            }
        }
    }
}
