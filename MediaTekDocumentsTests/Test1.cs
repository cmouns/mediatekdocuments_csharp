using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaTekDocuments.controller;
using System;

namespace MediaTekDocumentsTests
{
    [TestClass]
    public class FrmMediatekControllerTests
    {
        [TestMethod]
        public void TestParutionDansAbonnement()
        {
            // Arrange
            FrmMediatekController controller = new FrmMediatekController();
            DateTime dateCommande = new DateTime(2025, 01, 01);
            DateTime dateFinAbonnement = new DateTime(2025, 12, 31);

            // Parution en plein milieu de l'année qui doit être vrai
            DateTime dateParutionValide = new DateTime(2025, 06, 15);
            // Parution l'année suivante qui doit être faux
            DateTime dateParutionInvalide = new DateTime(2026, 01, 15);

            bool resultatValide = controller.ParutionDansAbonnement(dateCommande, dateFinAbonnement, dateParutionValide);
            bool resultatInvalide = controller.ParutionDansAbonnement(dateCommande, dateFinAbonnement, dateParutionInvalide);

            Assert.IsTrue(resultatValide, "La date valide devrait retourner true");
            Assert.IsFalse(resultatInvalide, "La date invalide devrait retourner false");
        }
    }
}