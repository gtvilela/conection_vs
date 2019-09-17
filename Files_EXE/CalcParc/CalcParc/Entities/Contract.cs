using System;
using System.Collections.Generic;

namespace CalcParc.Entities
{
    class Contract
    {
        public int NumCont { get; set; }
        public DateTime Date { get; set; }
        public double totalValue { get; set; }
        public List<Installment> Installments { get; set; }

        public Contract(int numCont, DateTime date, double totalValue)
        {
            NumCont = numCont;
            Date = date;
            this.totalValue = totalValue;
        }


        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}
