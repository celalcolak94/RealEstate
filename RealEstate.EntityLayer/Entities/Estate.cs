﻿using RealEstate.EntityLayer.Enums;

namespace RealEstate.EntityLayer.Entities
{
    public class Estate
    {
        public int EstateID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public string CoverPhoto { get; set; }
        public string Photo1 { get; set; }
        public string Photo2 { get; set; }
        public string Photo3 { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public int GrossSquareMeters { get; set; }
        public int NetSquareMeters { get; set; }
        public string Rooms { get; set; }
        public int BuildingAge { get; set; }
        public int NumberOfFloors { get; set; }
        public int FloorLocation { get; set; }
        public Heating Heating { get; set; }
        public int BathNumber { get; set; }
        public bool Balcony { get; set; }
        public bool Lift { get; set; }
        public CarPark CarPark { get; set; }
        public bool Furnished { get; set; }
        public bool UsingStatus { get; set; }
        public bool InSite { get; set; }
        public decimal Dues { get; set; }
        public DeedStatus DeadStatus { get; set; }
        public FromWho FromWho { get; set; }
        public bool Swap { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public bool HomePage { get; set; }
        public bool Status { get; set; }
    }
}
