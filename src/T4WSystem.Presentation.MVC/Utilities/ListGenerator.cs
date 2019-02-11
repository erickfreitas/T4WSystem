using System.Web.Mvc;

namespace T4WSystem.Presentation.MVC.Utilities
{
    public static class ListGenerator
    {
        public static SelectList GenerateDestinations()
        {
            return new SelectList(
                new[] {
                    new { Value = "", Label = "Destino" },
                    new { Value = "1003944", Label = "Miami" },
                    new { Value = "1010106", Label = "Orlando" },
                }, "Value", "Label");
        }

        public static SelectList GenerateAdultsNumbers()
        {
            return new SelectList(
                new[] {
                    new { Value = "", Label = "Adultos" },
                    new { Value = "1", Label = "1" },
                    new { Value = "2", Label = "2" },
                    new { Value = "3", Label = "3" },
                    new { Value = "4", Label = "4" },
                    new { Value = "5", Label = "5" },
                }, "Value", "Label");
        }

        public static SelectList GenerateChildAges()
        {
            return new SelectList(
                new[] {
                    new { Value = "", Label = "Idade das Crianças" },
                    new { Value = "0", Label = "Nenhuma" },
                    new { Value = "0", Label = "0" },
                    new { Value = "1", Label = "1" },
                    new { Value = "2", Label = "2" },
                    new { Value = "3", Label = "3" },
                    new { Value = "4", Label = "4" },
                    new { Value = "5", Label = "5" },
                    new { Value = "6", Label = "6" },
                }, "Value", "Label");
        }

        public static SelectList GenerateNumNights()
        {
            return new SelectList(
                new[] {
                    new { Value = "", Label = "Noites" },
                    new { Value = "1", Label = "1" },
                    new { Value = "2", Label = "2" },
                    new { Value = "3", Label = "3" },
                    new { Value = "4", Label = "4" },
                    new { Value = "5", Label = "5" },
                }, "Value", "Label");
        }

        public static SelectList GenerateRoomQuantity()
        {
            return new SelectList(
                new[] {
                    new { Value = "", Label = "Quartos" },
                    new { Value = "1", Label = "1" },
                    new { Value = "2", Label = "2" },
                    new { Value = "3", Label = "3" },
                    new { Value = "4", Label = "4" },
                    new { Value = "5", Label = "5" },
                }, "Value", "Label");
        }
    }
}