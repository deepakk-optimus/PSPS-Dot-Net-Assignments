using System;

namespace Induction
{
    class ATM
    {
        private int atmId;
        //private System.Threading.ReaderWriterLock rwl = new System.Threading.ReaderWriterLock();
        public static int totalTransaction = 0;

        public int AtmId
        {
            get
            {
                return atmId;
            }

            set
            {
                atmId = value;
            }
        }

        /*public System.Threading.ReaderWriterLock Rwl
        {
            get
            {
                return rwl;
            }

        }*/
    }
}
