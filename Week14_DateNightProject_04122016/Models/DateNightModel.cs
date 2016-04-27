using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Week14_DateNightProject_04122016.Models
{
    public class DateNightModel
    {
        /*Fields*/
        private string title;
        private string type;
        private string fullAddress;
        private string street;
        private string city;
        private string state;
        private string zip;
        private string phoneNum;
        private string photo;
        private string website;
        private double cost;

        /*Key Property*/
        [Key]
        public int RecordNum { get; set; }

        /*Properties*/
        [Display(Name = "Date Night Idea")]
        [StringLength(30, ErrorMessage = "The Date Night Idea can only contain 30 characters.")]
        [Required(ErrorMessage = "The Date Night Idea name is required.")]
        public string Title { get; set; }

        [Display(Name = "Date Type")]
        public string Type { get; set; }

        [Display(Name = "Date Full Address")]
        public string FullAddress { get; set; }

        [Display(Name = "Street Address")]
        public string Street { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }

        [Display(Name = "ZIP Code")]
        [StringLength(5, ErrorMessage = "ZIP Code must be 5 characters in length.")]
        public string Zip { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNum { get; set; }

        [Display(Name = "Image of Date Idea")]
        public string Photo { get; set; }

        [Display(Name = "Website")]
        /*[DataType(DataType.Url)]*/
        public string Website { get; set; }

        [Display(Name = "Cost per Person")]
        [Range(0, 1000, ErrorMessage = "Cost must be between $0.00 and $1000.00")]
        [DataType(DataType.Currency)]
        public double Cost { get; set; }

        /*Methods*/
        public void OrderByTypeTitle()
        {
        }

        List<string> typeList = new List<string>{"Nature", "Sports", "Restaurant", "Adventure", "Romantic", "Entertainment", "Music", "Museum", "Travel", "Family", "Educational"};
        /*typeList.Sort();  why doesn't this work?*/


    }
}