namespace Unosquare.PassCore.Web.Models
{
    using System.ComponentModel.DataAnnotations;

    public class UnlockAccountModel
    {
        [Required(ErrorMessage = nameof(ApiErrorCode.FieldRequired))]
        public string Username { get; set; }

        [Required(ErrorMessage = nameof(ApiErrorCode.FieldRequired))]
        public string ActivityDescription { get; set; }

        public string Recaptcha { get; set; }
    }
}
