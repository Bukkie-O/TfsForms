using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TfsForms.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedcrims : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "lkCRIMSLEAs",
                columns: new[] { "Id", "CRIMSDomain", "LEA" },
                values: new object[,]
                {
                    { 1, "army.mil.ng", "6 Military Intelligence Brigade" },
                    { 2, "abiairs.com", "Abia State Internal Revenue Service" },
                    { 3, "adamawabir.org", "Adamawa State Board Of Internal Revenue" },
                    { 4, "akirs.ak.gov.ng", "Akwa Ibom State Internal Revenue Service" },
                    { 5, "airs.an.gov.ng", "Anambra State Internal Revenue Service" },
                    { 6, "armu.gov.ng", "Asset Recovery Mgt Unit" },
                    { 7, "birs.bu.gov.ng", "Bauchi State Internal Revenue Service" },
                    { 8, "bir.by.gov.ng", "Bayelsa State Board Of Internal Revenue" },
                    { 9, "birs.be.gov.ng", "Benue State Internal Revenue Service" },
                    { 10, "cbn.gov.ng", "Central Bank of Nigeria" },
                    { 11, "china.foreign.mission", "China Foreign Mission" },
                    { 12, "ccb.gov.ng", "Code of Conduct Bureau (CCB)" },
                    { 13, "ccg.gov.ng", "Complex Cases Group" },
                    { 14, "cpc.gov.ng", "Consumer Protection Council" },
                    { 15, "cac.gov.ng", "Corporate Affairs Commissions" },
                    { 16, "crirs.ng", "Cross River Internal Revenue Service" },
                    { 17, "nafic.gov.ng", "DEACTIVATED-NAF Intel Corp" },
                    { 18, "dia.gov.ng", "Defence Intelligence Agency" },
                    { 19, "deltabir.com", "Delta State Internal Revenue Service" },
                    { 20, "dss.gov.ng", "Department of State Service (DSS)" },
                    { 21, "dmi.gov.ng", "Directorate of Military Intelligence" },
                    { 22, "efcc.gov.ng", "Economic and Financial Crimes Commission (EFCC)" },
                    { 23, "eirs.gov.ng", "Edo State IRS" },
                    { 24, "ekirs.gov.ng", "Ekiti State Internal Revenue Service" },
                    { 25, "enugustate.gov.ng", "Enugu State Internal Revenue Service" },
                    { 26, "fctirs.gov.ng", "FCT-IRS" },
                    { 27, "fccpc.gov.ng", "Federal Competition and Consumer Protection Commission" },
                    { 28, "firs.gov.ng", "Federal Inland Revenue Service" },
                    { 29, "fmoj.gov.ng", "Federal Ministry of Justice" },
                    { 30, "frsc.gov.ng", "Federal Road Safety Corp" },
                    { 31, "fciid.gov.ng", "Force Criminal Investigation and Intelligence Bureau" },
                    { 32, "gombe.igr.ng", "Gombe State Internal Revenue Service" },
                    { 33, "iirs.im.gov.ng", "Imo State Internal Revenue Service" },
                    { 34, "icpc.gov.ng", "Independent Corrupt Practices and Other Related Offences Commission (ICPC)" },
                    { 35, "intlcoop.gov.ng", "International Cooperation Department(Federal Ministry of Justice)" },
                    { 36, "interpol.com", "INTERPOL" },
                    { 37, "investigate.nfiu.gov.ng", "Investigate" },
                    { 38, "jic.gov.ng", "Joint Investigation Center" },
                    { 39, "kadirs.gov.ng", "Kaduna State Internal Revenue Service" },
                    { 40, "kirs.gov.ng", "Kano State Internal Revenue Service" },
                    { 41, "irs.kt.gov.ng", "Katsina State Internal Revenue Service" },
                    { 42, "irs.kg.gov.ng", "Kogi State Internal Revenue Service" },
                    { 43, "lirs.gov.ng", "Lagos State Internal Revenue Service" },
                    { 44, "mof.gov.ng", "Ministry of Finance" },
                    { 45, "irs.na.gov.ng", "Nasarawa State Internal Revenue Service" },
                    { 46, "nafdac.gov.ng", "National Agency for Food and Drug Administration" },
                    { 47, "naptip.gov.ng", "National Agency for the Prohibition of Trafficking in Persons" },
                    { 48, "ctc.gov.ng", "National Counter Terrorism Centre" },
                    { 49, "nccc.gov.ng", "National Cybersecurity Coordination Centre (NCCC)" },
                    { 50, "defencecollege@ndc.gov.ng", "National Defence College Nigeria" },
                    { 51, "ndlea.gov.ng", "National Drug Law Enforcement Agency" },
                    { 52, "nesrea.gov.ng", "National Environmental Standards and Regulations Enforcement Agency" },
                    { 53, "nimc.gov.ng", "National Identity Management Commission" },
                    { 54, "naicom.gov.ng", "National Insurance Commission" },
                    { 55, "nia.gov.ng", "National Intelligence Agency" },
                    { 56, "nlrc.gov.ng", "National Lottery Regulatory Commission" },
                    { 57, "navalic.gov.ng", "NAVAL Intel Corp" },
                    { 58, "ngsirs.gov.ng", "Niger State Internal Revenue Service" },
                    { 59, "nah.gov.ng", "Nigeria Army Head Quarters" },
                    { 60, "ncopyc.gov.ng", "Nigeria Copyright Commission" },
                    { 61, "nps.gov.ng", "Nigeria Correctional Service" },
                    { 62, "ncs.gov.ng", "Nigeria Customs Service" },
                    { 63, "ndic.gov.ng", "Nigeria Deposit Insurance Corporation" },
                    { 64, "neiti.gov.ng", "Nigeria Extractive Industries Transparency Initiative" },
                    { 65, "nis.gov.ng", "Nigeria Immigration Service" },
                    { 66, "npf.gov.ng", "Nigeria Police Force (NPF)" },
                    { 67, "npfamlcft.gov.ng", "Nigeria Police Force Anti-Money Laundering and Countering the Financing of Terrorism Section" },
                    { 68, "npfdo.gov.ng", "Nigeria Police Force Department of Operations (FCT Police Command)" },
                    { 69, "npfigpmu.gov.ng", "Nigeria Police Force IGP Monitoring Unit (NPF-IGPMU)" },
                    { 70, "npfirt.gov.ng", "Nigeria Police Force Intelligence Response Team (NPF-IRT)" },
                    { 71, "npflagoscom.gov.ng", "Nigeria Police Force Lagos Command" },
                    { 72, "psfu.gov.ng", "Nigeria Police Force, Police Special Fraud Unit (PSFU)" },
                    { 73, "nscdc.gov.ng", "Nigeria Security and Civil Defence Corps" },
                    { 74, "naf.gov.ng", "Nigerian Air Force Intel Corp" },
                    { 75, "nacmp.gov.ng", "Nigerian Army Corps of Military Police" },
                    { 76, "naic.gov.ng", "Nigerian Army Intelligence Corp" },
                    { 77, "opudokajtfse.gov.ng", "Nigerian Army OP UDO-KA (JTF-SE)" },
                    { 78, "ncc.gov.ng", "Nigerian Communication Commission" },
                    { 79, "crims.nfiu.gov.ng", "Nigerian Financial Intelligence Unit" },
                    { 80, "navy.gov.ng", "Nigerian Navy" },
                    { 81, "npfnccc.gov.ng", "NPF National Cybercrime Center (NPF-NCCC)" },
                    { 82, "onsa.gov.ng", "Office of the National Security Adviser" },
                    { 83, "ogirs.com", "Ogun State Internal Revenue Service" },
                    { 84, "odirs.ng", "ONDO STATE INTERNAL REVENUE SERVICE" },
                    { 85, "oirs.ng", "OSUN INTERNAL REVENUE SERVICE" },
                    { 86, "psirs.gov.ng", "Plateau State Internal Revenue Service" },
                    { 87, "sector1.na.gov.ng", "Sector 1: Theatre Command Nigeria Army" },
                    { 88, "sector2.na.gov.ng", "Sector 2: Theatre Command Nigeria Army" },
                    { 89, "sector3.na.gov.ng", "Sector 3: Theatre Command Nigeria Army" },
                    { 90, "sec.gov.ng", "Securities and Exchange Commission" },
                    { 91, "scuml.gov.ng", "Special Control Unit on Money Laundering (SCUML)" },
                    { 92, "sfu.gov.ng", "Special Fraud Unit" },
                    { 93, "spip.gov.ng", "Special Presidential Investigation Panel" },
                    { 94, "son.gov.ng", "Standard Organization of Nigeria" },
                    { 95, "tarababir.gov.ng", "Taraba State Internal Revenue Service" },
                    { 96, "test.org", "Test Organisation" },
                    { 97, "voars.gov.ng", "Voluntary Offshore Assets Regularization Scheme of Nigeria" },
                    { 98, "irs.zm.gov.ng", "Zamfara State Internal Revenue Service" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "lkCRIMSLEAs",
                keyColumn: "Id",
                keyValue: 98);
        }
    }
}
