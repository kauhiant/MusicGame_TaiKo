using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicGame
{
    public partial class Form1 : Form
    {
        public Graphics mainScene;
        private Bitmap tmpMainScene;
        private HitBar mainBar;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _backGraph.BackgroundImage = Image.FromFile(@"./backGround.png");

            _forntGraph.Parent = _backGraph;
            _forntGraph.BackColor = Color.Transparent;
            sceneInit();
            mainBar = new HitBar(mainScene);
            
        }

        private void sceneInit()
        {
            tmpMainScene = new Bitmap(_forntGraph.Size.Width , _forntGraph.Size.Height);
            mainScene = Graphics.FromImage(tmpMainScene);
        }
        public void ClearImage()
        {
            mainScene.Clear(_forntGraph.BackColor);
        }
        public void UpdateBattleImage()
        {
            _forntGraph.Image = tmpMainScene;
        }

        private int score = 0;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Space:
                    mainBar.addDon();
                    break;
                case Keys.A:
                    score += mainBar.hitDon();
                    this.Text = score.ToString();
                    break;
            }
        }

        private void _gameTimer_Tick(object sender, EventArgs e)
        {
            ClearImage();
            mainBar.step();
            UpdateBattleImage();
        }
    }
}
