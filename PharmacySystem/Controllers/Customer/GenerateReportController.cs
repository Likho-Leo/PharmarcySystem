using DinkToPdf.Contracts;
using DinkToPdf;
using Microsoft.AspNetCore.Mvc;

namespace PharmacySystem.Controllers.Customer
{
    public class GenerateReportController : Controller
    {
        public IActionResult GenerateReport()
        {
            return View("~/Views/Customer/GenerateReport/GenerateReport.cshtml");
        }
        private readonly IConverter _converter;

        public GenerateReportController(IConverter converter)
        {
            _converter = converter;
        }

        public IActionResult GeneratePdfGroupedByPatient()
        {
            var doc = new HtmlToPdfDocument()
            {
                GlobalSettings = {
                PaperSize = PaperKind.A4,
                Orientation = Orientation.Portrait
            },
                Objects = {
                    new ObjectSettings() {
                        HtmlContent = @"
                            <h1 style='text-align:center;'>📄 Patient Prescription Report</h1>
                            <hr />
                            <h3>Patient: John Doe</h3>
                            <p><strong>Doctor:</strong> Dr. Smith</p>
                            <p><strong>Date:</strong> 2025-06-07</p>
                            <table style='width:100%; border-collapse:collapse;' border='1'>
                                <thead>
                                    <tr>
                                        <th style='padding:8px;'>Medication</th>
                                        <th style='padding:8px;'>Dosage</th>
                                        <th style='padding:8px;'>Frequency</th>
                                        <th style='padding:8px;'>Dispensed On</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td style='padding:8px;'>Paracetamol</td>
                                        <td style='padding:8px;'>500mg</td>
                                        <td style='padding:8px;'>3x Daily</td>
                                        <td style='padding:8px;'>2025-06-01</td>
                                    </tr>
                                    <tr>
                                        <td style='padding:8px;'>Ibuprofen</td>
                                        <td style='padding:8px;'>200mg</td>
                                        <td style='padding:8px;'>2x Daily</td>
                                        <td style='padding:8px;'>2025-06-03</td>
                                    </tr>
                                </tbody>
                            </table>
                        ",

                        WebSettings = { DefaultEncoding = "utf-8" }
                    }
                }
            };

            var pdf = _converter.Convert(doc);
            return File(pdf, "application/pdf", "SampleReport.pdf");
        }

        public IActionResult GenerateGroupedByMedicationPdf()
        {
            var doc = new HtmlToPdfDocument()
            {
                GlobalSettings = {
            PaperSize = PaperKind.A4,
            Orientation = Orientation.Portrait
        },
                Objects = {
            new ObjectSettings() {
                HtmlContent = @"
                    <h1 style='text-align:center;'>💊 Prescription Summary - Grouped by Medication</h1>
                    <hr />
                    <h3>Patient: John Doe</h3>
                    <p><strong>Doctor:</strong> Dr. Smith</p>
                    <p><strong>Date:</strong> 2025-06-07</p>
                    
                    <h4>Paracetamol</h4>
                    <table style='width:100%; border-collapse:collapse;' border='1'>
                        <thead>
                            <tr>
                                <th style='padding:8px;'>Dosage</th>
                                <th style='padding:8px;'>Frequency</th>
                                <th style='padding:8px;'>Dispensed On</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td style='padding:8px;'>500mg</td>
                                <td style='padding:8px;'>3x Daily</td>
                                <td style='padding:8px;'>2025-06-01</td>
                            </tr>
                        </tbody>
                    </table>

                    <h4>Ibuprofen</h4>
                    <table style='width:100%; border-collapse:collapse;' border='1'>
                        <thead>
                            <tr>
                                <th style='padding:8px;'>Dosage</th>
                                <th style='padding:8px;'>Frequency</th>
                                <th style='padding:8px;'>Dispensed On</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td style='padding:8px;'>200mg</td>
                                <td style='padding:8px;'>2x Daily</td>
                                <td style='padding:8px;'>2025-06-03</td>
                            </tr>
                        </tbody>
                    </table>
                ",
                WebSettings = { DefaultEncoding = "utf-8" }
            }
        }
            };

            var pdf = _converter.Convert(doc);
            return File(pdf, "application/pdf", "GroupedByMedication.pdf");
        }

        public IActionResult GeneratePdfGroupedByDoctor()
        {
            var doc = new HtmlToPdfDocument()
            {
                GlobalSettings = {
                PaperSize = PaperKind.A4,
                Orientation = Orientation.Portrait
            },
                Objects = {
                    new ObjectSettings() {
                        HtmlContent = @"
                            <h1 style='text-align:center;'>📄 Prescription Report by Doctor</h1>
                            <hr />
                            <h3>Doctor: Dr. Smith</h3>
                            <p><strong>Patient:</strong> Jane Roe</p>
                            <table style='width:100%; border-collapse:collapse;' border='1'>
                                <thead>
                                    <tr>
                                        <th style='padding:8px;'>Medication</th>
                                        <th style='padding:8px;'>Dosage</th>
                                        <th style='padding:8px;'>Frequency</th>
                                        <th style='padding:8px;'>Date Dispensed</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td style='padding:8px;'>Ibuprofen</td>
                                        <td style='padding:8px;'>200mg</td>
                                        <td style='padding:8px;'>3x Daily</td>
                                        <td style='padding:8px;'>2025-06-02</td>
                                    </tr>
                                </tbody>
                            </table>
                        ",
                        WebSettings = { DefaultEncoding = "utf-8" }
                    }
                }
            };

            var pdf = _converter.Convert(doc);
            return File(pdf, "application/pdf", "GroupedByDoctor.pdf");
        }
    }

}
