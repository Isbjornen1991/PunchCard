namespace StampCardApp
{
    public class StampCard
    {
        //Mandatory
        public string OwnerName { get; private set; }
        public int Stamps { get; private set; }

        //Extra
        private bool _isBlocked = false;
        private static bool _isDoubleStampDay = false;

        public StampCard(string ownerName)
        {
            if (string.IsNullOrWhiteSpace(ownerName))
            {
                throw new ArgumentException("Owner name cannot be empty.", nameof(ownerName));
            }

            OwnerName = ownerName;
            Stamps = 0;
        }

        public void AddStamp()
        {
            if (_isBlocked)
            {
                return;
            }

            Stamps = Stamps + 1;

            if (_isDoubleStampDay)
            {
                Stamps = Stamps + 1;
            }
        }

        public void SetDoubleStampDay()
        {
            if (!_isDoubleStampDay)
            {
                _isDoubleStampDay = true;
            }
            else
            {
                _isDoubleStampDay = false;
            }
        }

        // Primitive/Simple Solution
        //public void DoubleStamp()
        //{
        //    AddStamp();
        //    AddStamp();
        //}

        // Alternative approach with bool param
        //public void AddStamp(bool _isDoubleStampDay = false)
        //{
        //    if (_isBlocked)
        //    {
        //        return;
        //    }

        //    Stamps = Stamps + 1;

        //    if (_isDoubleStampDay)
        //    {
        //        Stamps = Stamps + 1;
        //    }
        //}


        public bool RedeemFreeCoffee()
        {
            if (Stamps < 10 || _isBlocked)
            {
                return false;
            }
            Stamps = Stamps - 10;
            return true;
        }

        public void SetIsBlocked()
        {
            _isBlocked = true;
        }
    }
}
