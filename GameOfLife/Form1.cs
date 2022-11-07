namespace GameOfLife
{
    public partial class MainGame : Form
    {
        Boolean InProgress;
        int liveCellCount;

        public MainGame()
        {
            InitializeComponent();
        }

        private void MainGame_Load(object sender, EventArgs e)
        {
            CreateGrid();
        }

        private void CreateGrid()
        {
            Point locationPoint;
            Cell newCell;

            Random random = new Random();

            int rows = (int)(pbGrid.Height / numCSize.Value);
            int cols = (int)(pbGrid.Width / numCSize.Value);

            using(Bitmap bmp = new Bitmap(pbGrid.Width, pbGrid.Height))
            using(Graphics g = Graphics.FromImage(bmp))
            using (SolidBrush cellBrush = new SolidBrush(Color.Purple))
            {
                g.Clear(Color.Black);
                pbGrid.Image = (Bitmap)bmp.Clone();

                Cell.gridCells.Clear();

                for (int y = 0; y < rows; y++)
                {
                    for (int x = 0; x < cols; x++)
                    {
                        locationPoint = new Point((int)(x*numCSize.Value), (int)(y*numCSize.Value));

                        newCell = new Cell(locationPoint, x, y);
                        newCell.IsAlive = (random.Next(100) < liveCellCount) ? true: false;

                        Cell.gridCells.Add(newCell);
                    }
                }

                foreach (Cell cell in Cell.gridCells)
                {
                    if (cell.IsAlive)
                    {
                        g.FillRectangle(cellBrush, new Rectangle(cell.Location, new Size((int)numCSize.Value - 1, (int)numCSize.Value - 1)));
                        //oduzeto je 1 da bi bilo malo razmaka izmedu celija
                    }
                }

                pbGrid.Image = (Bitmap)bmp.Clone();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            CreateGrid();
        }

        private void GetNextState()
        {
            /*Every cell interacts with its eight neighbours, which are the cells that are horizontally, vertically, or diagonally adjacent. At each step in time, the following transitions occur:

                Any live cell with fewer than two live neighbours dies, as if by underpopulation.
                Any live cell with two or three live neighbours lives on to the next generation.
                Any live cell with more than three live neighbours dies, as if by overpopulation.
                Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.
                
            These rules, which compare the behavior of the automaton to real life, can be condensed into the following:

                Any live cell with two or three live neighbours survives.
                Any dead cell with three live neighbours becomes a live cell.
                All other live cells die in the next generation. Similarly, all other dead cells stay dead.*/

            foreach (Cell cell in Cell.gridCells)
            {
                int activeCount = cell.LiveNeighbours();

                if (cell.IsAlive)
                {
                    if ((activeCount < 2) || (activeCount > 3)) //celija s manje od 2 ili vise od 3 susjeda umire
                    {
                        cell.NextStatus = false;
                    }
                    else
                    {
                        cell.NextStatus = true;
                    }
                }
                else
                {
                    if (activeCount == 3)  //ako celija ima 3 susjeda onda je ziva (ako je bila mrtva, ozivi)
                    {
                        cell.NextStatus = true;
                    }
                }
            }

            foreach (Cell cell in Cell.gridCells)
            {
                cell.IsAlive = cell.NextStatus;
            }

            using (Bitmap bmp = new Bitmap(pbGrid.Width, pbGrid.Height))
            using (Graphics g = Graphics.FromImage(bmp))
            using (SolidBrush cellBrush = new SolidBrush(Color.Purple))
            {
                g.Clear(Color.Black);

                foreach (Cell cell in Cell.gridCells)
                {
                    if (cell.IsAlive)
                    {
                        g.FillRectangle(cellBrush, new Rectangle(cell.Location, new Size((int)numCSize.Value - 1, (int)numCSize.Value - 1)));
                    }
                }

                pbGrid.Image.Dispose();
                pbGrid.Image = (Bitmap)bmp.Clone();
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            InProgress = !InProgress;

            btnGo.Text = InProgress ? "Stop" : "Go";

            while (InProgress)
            {
                GetNextState();
                Application.DoEvents();
            }
        }

        private void MainGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            InProgress = false;
            Application.Exit();
        }

        private void cbLiveCells_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbLiveCells.SelectedIndex)
            {
                case 0:
                    liveCellCount = 10;
                    break;
                case 1:
                    liveCellCount = 15;
                    break;
                case 2:
                    liveCellCount = 20;
                    break;
            }
        }
    }

    public class Cell
    {
        public static List<Cell> gridCells = new List<Cell>();

        private Point cellLocation;
        private int cellXPosition;
        private int cellYPosition;
        private Boolean cellIsAlive;
        private Boolean cellNext;

        public Cell(Point location, int X, int Y)
        {
            this.Location = location;
            this.XPosition = X;
            this.YPosition = Y;
        }

        public Point Location
        {
            get { return cellLocation; }
            set { cellLocation = value; }
        }

        public int XPosition
        {
            get { return cellXPosition; }
            set { cellXPosition = value; }
        }

        public int YPosition
        {
            get { return cellYPosition; }
            set { cellYPosition = value; }
        }

        public Boolean IsAlive
        {
            get { return cellIsAlive; }
            set { cellIsAlive = value; }
        }

        public Boolean NextStatus
        {
            get { return cellNext; }
            set { cellNext = value; }
        }


        public int LiveNeighbours()
        {
            int liveNeighbours = 0;

            foreach (Cell cell in Cell.gridCells)
            {
                //gledaju se po koordinatama celije koje su odmah do trenutne celije
                if (Math.Abs(cell.XPosition - this.XPosition) < 2 && Math.Abs(cell.YPosition - this.YPosition) < 2)
                {
                    //celija koja se gleda nije trenutna celija i ziva je
                    if (cell.Location != this.Location && cell.IsAlive)
                    {
                        liveNeighbours++;
                    }
                }
            }

            return liveNeighbours;
        }
    }
}