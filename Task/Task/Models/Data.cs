using System.Collections.Generic;
using System.ComponentModel;

namespace Task.Models
{
    public static class Data
    {
        public static List<Service> services = new List<Service>
        {
            new Service{Id=1, Title="Lorem Ipsum", Icon="bx bxl-dribbble", Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi" },
            new Service{Id=2, Title="Sed ut perspiciatis", Icon="bx bx-file", Desc="Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore" },
            new Service{Id=3, Title="Dele cardo", Icon="bx bx-tachometer", Desc="Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia" },
            new Service{Id=4, Title="Magni Dolores", Icon="bx bx-world", Desc="At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis" },
            new Service{Id=5, Title="Nemo Enim", Icon="bx bx-slideshow", Desc="Quis consequatur saepe eligendi voluptatem consequatur dolor consequuntur" },
            new Service{Id=6, Title="Divera don", Icon="bx bx-arch", Desc="Modi nostrum vel laborum. Porro fugit error sit minus sapiente sit aspernatur" }
        };

        public static List<Team> teams = new List<Team>
        {
            new Team{Id=1, Title="Walter White", BgImg="../assets/img/team/team-1.jpg", Desc="Chief Executive Officer",Icon1="bi bi-twitter", Icon2="bi bi-facebook", Icon3="bi bi-instagram", Icon4="bi bi-linkedin"},
            new Team{Id=2, Title="Sarah Johnson", BgImg="../assets/img/team/team-2.jpg", Desc = "Product Manager",Icon1="bi bi-twitter", Icon2="bi bi-facebook", Icon3="bi bi-instagram", Icon4="bi bi-linkedin"},
            new Team{Id=3, Title="William Anderson", BgImg="../assets/img/team/team-3.jpg", Desc="CTO",Icon1="bi bi-twitter", Icon2="bi bi-facebook", Icon3="bi bi-instagram", Icon4="bi bi-linkedin"},
            new Team{Id=4, Title="Amanda Jepson", BgImg="../assets/img/team/team-4.jpg",Desc="Accountant",Icon1="bi bi-twitter", Icon2="bi bi-facebook", Icon3="bi bi-instagram", Icon4="bi bi-linkedin"}
        };

        public static List<Contact> Contacts = new List<Contact>
        {
            new Contact{Id=1, Icon="bx bx-map", Title="Our Address", Desc="A108 Adam Street, New York, NY 535022"},
            new Contact{Id=2, Icon="bx bx-envelope", Title="Email Us", Desc="contact@example.com"},
            new Contact{Id=3, Icon="bx bx-phone-call", Title="Call Us", Desc="+1 5589 55488 55"}
        };
        

        
        
    }
}
