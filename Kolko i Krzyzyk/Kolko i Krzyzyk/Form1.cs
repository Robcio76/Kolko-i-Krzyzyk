namespace Kolko_i_Krzyzyk
{
    public partial class Form1 : Form
    {
        int[,] board = new int[20, 20];
        
        public Form1()
        {
            InitializeComponent();
        }
        int player = 1;

      
        

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen blackPen = new Pen(Color.Black, 2);

            g.DrawRectangle(Pens.Black, 0, 0, 400, 400);

            for (int i = 0; i < 21; i++)
            {
                g.DrawLine(Pens.Black, -400, 20 * i, 400, 20 * i);
            }

            for(int j = 0; j < 21; j++)
            {
                g.DrawLine(Pens.Black, 20*j, -400, 20*j, 400);
            }

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (board[i, j]==1)
                    {
                        g.DrawEllipse(blackPen, 20 * i, 20 * j, 20, 20);
                        
                    }
                    if (board[i, j] == 2)
                    {
                        g.DrawLine(blackPen, 20*i, 20*j, 20*i+20, 20*j+20);
                        g.DrawLine(blackPen, 20*i, 20*j+20, 20*i+20, 20*j);

                    }
                }
            }bool win(char board[20][20], string &result) {
     for (int i = 0; i < 3; ++ i) {
        if ((board[i][0] != 0) && (board[i][0] == board[i][1]) 
                        && (board[i][1] == board[i][2])) {
            result = board[i][0];
            return true;
        }
        if ((board[0][i] != 0) && (board[0][i] == board[1][i]) 
                        && (board[1][i] == board[2][i])) {
            result = board[0][i];
            return true;
        }            
    }
    if ((board[1][1] != 0) && (board[0][0] == board[1][1]) 
                        && (board[1][1] == board[2][2])) {
        result = board[1][1];
        return true;
    }
    if ((board[1][1] != 0) && (board[0][2] == board[1][1]) 
                        && (board[1][1] == board[2][0])) {
        result = board[1][1];
        return true;
    }        
    return false;
}
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;


            if (board[x/20, y/20] == 1 | board[x/20, y/20] == 2)
            {
                return;
            }
            
                board[x / 20, y / 20] = player;
            
            
                if (player == 1)
                {
                    player = 2;
                }
                else
                {
                    player = 1;
                }
            


            pictureBox1.Invalidate();
        }
    }
}
