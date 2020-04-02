using System;
using Microsoft.ML.Data;

namespace precioTaxiML.DataStructures
{
    public class TaxiTripFarePrediction
    {
        [ColumnName("Score")]
        public float FareAmount;
    }
}
