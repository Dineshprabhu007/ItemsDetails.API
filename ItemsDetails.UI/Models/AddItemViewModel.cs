namespace ItemsDetails.UI.Models
{
    public class AddItemViewModel
    {
        public string Client_Code { get; set; }

        public string Item_Number { get; set; }

        public string Display_Item_Number { get; set; }

        public string? Description { get; set; }

        public string Uom { get; set; }

        public int Price { get; set; }

        public string High_Value_Indicator { get; set; }
    }
}
