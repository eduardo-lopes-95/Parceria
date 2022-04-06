using Microsoft.EntityFrameworkCore;
using MimeKit;
using MimeKit.Text;

namespace Parceria.Data
{
    internal static class ConviteRepository
    {
        internal async static Task<List<Convite>> GetConvitesAsync()
        {
            using(var db = new AppDBContext())
            {
                return await db.Convites.ToListAsync();
            }
        }

        internal async static Task<bool> CreateConviteAsync(Convite convite)
        {
            using (var db = new AppDBContext())
            {
                try
                {
                    await db.Convites.AddAsync(convite);
                    return await db.SaveChangesAsync() >= 1;
                }
                catch (Exception)
                {

                    return false;
                }
            }

        }

        internal static MimeMessage CreateEmailMessage(string emailDest)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("transferoparceiro@transferoswiss.com.br"));
            email.To.Add(MailboxAddress.Parse(emailDest));
            email.Subject = "Sistema Parceiro Transfero";
            email.Body = new TextPart(TextFormat.Html)
            {
                Text = $"Você esta sendo convidado a participar do sistema transfero",
            };
            
            return email;
        }

        //Criar o e-mail

        //Enviar o convite por e-mail
    }
}
