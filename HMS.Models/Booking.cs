﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace HMS.Models
{
    [DataContract(IsReference = true)]
    public class Booking
    {
        [Key]
        [Required]
        [DataMember]
        public int BookingId { get; set; }

        [DataMember]
        public DateTime BookingDate { get; set; }

        [Required]
        [DataMember]
        public DateTime BookingArrivalDate { get; set; }

        [Required]
        [DataMember]
        public DateTime BookingDepartureDate { get; set; }

        [DataMember]
        public int RoomCategoryId { get; set; }

        [DataMember]
        public int RoomId { get; set; }
        [ForeignKey("RoomId")]
        public virtual Room Room { get; set; }

        [DataMember]
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

        [DataMember]
        public bool BookingStatus { get; set; }

        [DataMember]
        public int BookingTotalNights { get; set; }

        [DataMember]
        public int BookingTotalRooms { get; set; }

        [Required]
        [DataMember]
        public int BookingTotalAdults { get; set; }

        [Required]
        [DataMember]
        public int BookingTotalChilds { get; set; }

        [DataMember]
        public double BookingTotalCost { get; set; }

        //* Navigation Properties*/
        //[DataMember]
        //public ICollection<RoomCapacity> RoomCapacities { get; set; }

        //[DataMember]
        //public ICollection<Room> Rooms { get; set; }

        //[DataMember]
        //public ICollection<RoomCategory> RoomCategories { get; set; }

        //public Booking()
        //{
        //    RoomCategories = new Collection<RoomCategory>();
        //    RoomCapacities = new Collection<RoomCapacity>();
        //    Rooms = new Collection<Room>();
        //}
    }
}
