namespace StampCardApp
{
    public class StampCard
    {
        public string OwnerName { get; private set; }
        public int Stamps { get; private set; }

        private bool isBlocked = false;

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
            if (!isBlocked)
            {
                Stamps = Stamps + 1;
            }
        }

        public void DoubleStamp()
        {
            AddStamp();
            AddStamp();
        }


        public bool RedeemFreeCoffee()
        {
            if (Stamps < 10 || isBlocked)
            {
                return false;
            }
            Stamps = Stamps - 10;
            return true;
        }

        public void SetIsBlocked()
        {
            isBlocked = true;
        }
    }
}
