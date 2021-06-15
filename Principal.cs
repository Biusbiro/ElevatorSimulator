using Elevator_Simulator.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator_Simulator
{
    public partial class Principal : Form
    {
        #region properties
        const int SHAFT = 552;
        const int FIRSTFLOOR = 0;
        const int LASTFLOOR = 6;
        public int ElevatorBreak { get; set; }
        public List<KeyValuePair<int, Point>> Floors { get; set; }
        #endregion

        #region events
        private void btnUp_Click(object sender, EventArgs e)
        {
            MoveElevator(EElevatorAction.MoveUp);
        }
        private void btnDown_Click(object sender, EventArgs e)
        {
            MoveElevator(EElevatorAction.MoveDown);
        }
        #endregion

        #region constructors
        public Principal()
        {
            InitializeComponent();
            Floors = GetFloors();
            ElevatorBreak = FIRSTFLOOR;
            pbxElevator.Location = Floors.FirstOrDefault().Value;
        }
        #endregion

        #region private methods
        private List<KeyValuePair<int, Point>> GetFloors()
        {
            var floors = new List<KeyValuePair<int, Point>>();
            floors.Add(new KeyValuePair<int, Point>( 0, new Point(SHAFT, (int)EFloors.Floor0)));
            floors.Add(new KeyValuePair<int, Point>( 1, new Point(SHAFT, (int)EFloors.Floor1)));
            floors.Add(new KeyValuePair<int, Point>( 2, new Point(SHAFT, (int)EFloors.Floor2)));
            floors.Add(new KeyValuePair<int, Point>( 3, new Point(SHAFT, (int)EFloors.Floor3)));
            floors.Add(new KeyValuePair<int, Point>( 4, new Point(SHAFT, (int)EFloors.Floor4)));
            floors.Add(new KeyValuePair<int, Point>( 5, new Point(SHAFT, (int)EFloors.Floor5)));
            floors.Add(new KeyValuePair<int, Point>( 6, new Point(SHAFT, (int)EFloors.Floor6)));
            return floors;
        }

        private void MoveElevator(EElevatorAction action)
        {
            var current = Floors.Where(obj => obj.Key == ElevatorBreak).FirstOrDefault().Value;
            var nextUp = Floors.Where(obj => obj.Key == ElevatorBreak + 1).FirstOrDefault().Value;
            var nextDown = Floors.Where(obj => obj.Key == ElevatorBreak - 1).FirstOrDefault().Value;

            switch (action)
            {
                case EElevatorAction.MoveUp:
                    if (ElevatorBreak == LASTFLOOR)
                        break;
                    Animation(current, nextUp);
                    ElevatorBreak ++;
                    break;
                case EElevatorAction.MoveDown:
                    if (ElevatorBreak == FIRSTFLOOR)
                        break;
                    Animation(current, nextDown);
                    ElevatorBreak --;
                    break;
                default:
                    break;
            }
        }

        private void Animation(Point current, Point next)
        {
            var movimentationTime = 10;

            var action = current.Y > next.Y
                ? EElevatorAction.MoveUp
                : EElevatorAction.MoveDown;

            if (action ==  EElevatorAction.MoveUp)
                for (int YAxix = current.Y ; YAxix >= next.Y ; YAxix --)
                {
                    Thread.Sleep(movimentationTime);
                    pbxElevator.Location = new Point(current.X, YAxix);
                }

            if (action == EElevatorAction.MoveDown)
                for (int YAxix = current.Y; YAxix <= next.Y; YAxix ++)
                {
                    Thread.Sleep(movimentationTime);
                    pbxElevator.Location = new Point(current.X, YAxix);
                }

        }
        #endregion
    }
}
