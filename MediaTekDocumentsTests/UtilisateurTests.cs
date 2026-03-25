using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaTekDocuments.model;

namespace MediaTekDocumentsTests.model
{
    [TestClass]
    public class UtilisateurTests
    {
        [TestMethod]
        public void Utilisateur_Initialisation_Correcte()
        {
            string id = "1";
            string nom = "Dupont";
            string prenom = "Jean";
            string service = "Prêts";

            Utilisateur user = new Utilisateur(id, nom, prenom, service);

            Assert.AreEqual(id, user.Id, "L'ID devrait correspondre.");
            Assert.AreEqual(service, user.Service, "Le service devrait être 'Prêts'.");
        }
    }
}