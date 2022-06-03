using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSW.Model
{
    public enum Location
    {
        Home = 0,
        RegistartionModule,
        CheckModule,
        TechModule,
        MainModule
    }

    public class Player
    {
        public delegate void MoveHandler(Location from, Location to);
        public event MoveHandler OnMove;

        public delegate void TimeHandler(int hours, int minutes);
        public event TimeHandler OnTimeUpdated;

        public delegate void DayHandler(int day);
        public event DayHandler OnDayUpdated;

        private Location _currentLocation;
        public Location CurrentLocation => _currentLocation;

        public int CurrentDay { get; private set; }
        public DateTime CurrentTime { get; private set; }

        private Random _random;

        public Player()
        {
            _random = new Random(DateTime.Now.Millisecond);
            _currentLocation = Location.Home;
            SetMorningTime();
        }

        private void SetMorningTime()
        {
            int minutes = _random.Next(4, 60);
            string time = $"10:{minutes:00}";
            CurrentTime = DateTime.ParseExact(time, "HH:mm", System.Globalization.CultureInfo.InvariantCulture);
            OnTimeUpdated?.Invoke(CurrentTime.Hour, CurrentTime.Minute);
        }

        public void Move(Location to, int minutes)
        {
            if (_currentLocation == to || to != Location.Home && CurrentTime.Hour >= 18)
                return;

            OnMove.Invoke(_currentLocation, to);
            CurrentTime = CurrentTime.AddMinutes(minutes);
            OnTimeUpdated.Invoke(CurrentTime.Hour, CurrentTime.Minute);
            _currentLocation = to;
        }

        public bool IsTimeToSleep()
        {
            const int sleepTime = 18;
            return CurrentTime.Hour >= sleepTime;
        }

        public void Sleep()
        {
            SetMorningTime();
            CurrentDay++;
            OnDayUpdated?.Invoke(CurrentDay);
        }
    }
}
