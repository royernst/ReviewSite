using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReviewSite.Models
{
    public class Review
    {
        //Setting up class properties and key ID
        [Key]
        public int ReviewID { get; set; }

        //setting the Foreign Key reference to link this model with the Category model.
        //decided to place first for user convenience
        [ForeignKey("Category"), Display(Name = "Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        //MinLength 1 to ensure field is populated.  MaxLength 50 to ensure succinct review titles that grab attention and to
        //help increase security against javascript injection
        [MinLength(1), MaxLength(50), Display(Name = "Review Title")]
        public string Title { get; set; }

        //Quick summary tagline for a title, not required for publication
        [MaxLength(50), Display(Description = "Max of 50 characters")]
        public string Tagline { get; set; }

        //Author name -- limited to 20 chars max, min of 2
        [MinLength(2), MaxLength(20), Display(Name = "Review Author")]
        public string Author { get; set; }

        //Date review was published in DateTime format -- look into removing time from input and formatting input box into poss dropdown
        [Display(Name = "Date of Publishment", Description = "Month/Day/Year format")]
        public DateTime PublishedDate { get; set; }

        //Number of stars given for a review with range min 1 max 5
        [Range(1, 5), Display(Name = "Rating")]
        public int StarRating { get; set; }

        //For storage purposes, MaxLength is set to 500 characters.  On a normal site, would be MUCH longer and include an option
        //to add images to the content
        [MaxLength(500)]
        public string Content { get; set; }
    }
}