using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignLookupService.Models
{
    public class Sign
    {
        public int ID { get; set; }
        public ColorType Color { get; set; }
        public ShapeType Shape { get; set; }
        public SymbolType Symbol { get; set; }
        public string Description { get; set; }
        public int NumberOfAttributes { get; set; }

    }

    public enum ColorType
    {
        Yellow,
        Red,
        Blue,
        White
    }

    public enum ShapeType
    {
        Circle,
        Square,
        Triangle
    }

    public enum SymbolType
    {
        NoParking,
        Warning,
        Parking,
        DateParking,
        ArrowUp,
        ArrowDown,
        ArrowLeft,
        ArrowRight,
        Handicap
    }
}