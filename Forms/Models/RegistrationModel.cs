namespace Forms.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class RegistrationModel
    {
        [Required(ErrorMessage = "Pole Imię jest wymagane.")]
        [MinLength(2, ErrorMessage = "Imię musi mieć co najmniej 2 znaki.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Pole Nazwisko jest wymagane.")]
        [MinLength(2, ErrorMessage = "Nazwisko musi mieć co najmniej 2 znaki.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Pole Adres e-mail jest wymagane.")]
        [EmailAddress(ErrorMessage = "Podaj poprawny adres e-mail.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Pole Hasło jest wymagane.")]
        [MinLength(8, ErrorMessage = "Hasło musi mieć co najmniej 8 znaków.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$", ErrorMessage = "Hasło musi zawierać co najmniej jedną cyfrę, jedną dużą literę i jedną małą literę.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Pole Potwierdzenie hasła jest wymagane.")]
        [Compare("Password", ErrorMessage = "Potwierdzenie hasła musi być identyczne z hasłem.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Pole Nr telefonu jest wymagane.")]
        [Phone(ErrorMessage = "Podaj poprawny numer telefonu.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Pole Wiek jest wymagane.")]
        [Range(10, 80, ErrorMessage = "Wiek musi być w zakresie od 10 do 80 lat.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Pole Miasto jest wymagane.")]
        public string City { get; set; }

        public enum Cities
        {
            City1,
            City2,
            City3,
            City4,
            City5
        }
    }

}
