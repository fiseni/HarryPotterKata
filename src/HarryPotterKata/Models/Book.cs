using HarryPotterKata.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace HarryPotterKata.Models
{
    public class Book
    {
        public double BookPrice { get; } = 8;
        public BookVolumeEnum BookVolume { get; }

        public Book(BookVolumeEnum bookVolume)
        {
            BookVolume = bookVolume;
        }
    }
}
