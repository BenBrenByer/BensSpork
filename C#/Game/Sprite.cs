using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace Game
{
    public class Sprite
    {
        public PictureBox m_ball1;
        public PictureBox m_ball2;
        public PictureBox m_ball3;
        public PictureBox m_ball4;
        public PictureBox m_ball5;
        public PictureBox m_picture;
        public Label m_healthlabel;
        public Point m_location;
        public int m_speed = 5;
        public Canvas m_parent;
        public Sprite(PictureBox picture, PictureBox ball1, PictureBox ball2, PictureBox ball3, PictureBox ball4, PictureBox ball5)
        {
            m_picture = picture;
            m_location = picture.Location;
            m_ball1 = ball1;
            m_ball2 = ball2;
            m_ball3 = ball3;
            m_ball4 = ball4;
            m_ball5 = ball5;
        }
        
        public void setParent(Canvas parent)
        {
            m_parent = parent;
        }
        public Form1 GetForm1() { return m_parent.m_parent; }
        public virtual void tick()
        {
            movedown();
        }
        virtual public bool collision(PictureBox other)
        {
            if (other.Image == Ballpicture.Picturebox) ;
            {
                //Form1.m_healthlabel 
                Environment.Exit(0);
                    }
            Debug.Print(m_picture.Name + " collided with " + other.Name);
            return false;//  don't go through stuff
        }
        public void move(int X, int Y)
        {
            if (!m_parent.moveTo(m_picture, m_speed * X, m_speed * Y))
               return;
            m_location = new Point(m_location.X + m_speed * X, m_location.Y + m_speed * Y);
            m_picture.Location = m_location;

        }
        public void moveleft()
        {
            move(-1, 0);
        }
        public void moveright()
        {
            move(1, 0);
        }
        public void moveup()
        {
            move(0, -1);
        }
        public void movedown()
        {
            move(0, 1);
        }
    }

}
