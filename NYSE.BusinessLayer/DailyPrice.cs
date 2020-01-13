using System;
using System.ComponentModel.DataAnnotations;

namespace NYSE.BusinessLayer
{
    public class DailyPrice
    {
        // base daily price class

        public int Id { get; set; }

        [Required(ErrorMessage ="Date is a required field")]
        public DateTime date { get; set; }

        [Required(ErrorMessage = "Stock symbol is a required field")]
        public string stock_symbol { get; set; }

        [Required(ErrorMessage = "Open Price is a required field")]
        public decimal stock_price_open { get; set; }

        [Required(ErrorMessage = "Close Price is a required field")]
        public decimal stock_price_close { get; set; }

        [Required(ErrorMessage = "Low Price is a required field")]
        public decimal stock_price_low { get; set; }

        [Required(ErrorMessage = "High Price is a required field")]
        public decimal stock_price_high { get; set; }

        [Required(ErrorMessage = "Adj. Close Price is a required field")]
        public decimal stock_price_adj_close { get; set; }

        [Required(ErrorMessage = "Volume is a required field")]
        public int stock_volume { get; set; }

        [Required(ErrorMessage = "Stock Exchange is a required field")]
        public string stock_exchange { get; set; }

        // default constructor
        public DailyPrice()
        {
            // blank
        }

        // overloaded constructor
        public DailyPrice(DateTime _date,
                string _stock_symbol,
                decimal _stock_price_open,
                decimal _stock_price_close,
                decimal _stock_price_low,
                decimal _stock_price_high,
                decimal _stock_price_adj_close,
                int _stock_volume,
                string _stock_exchange
                )
        {
            // add properties to object

            try
            {

                date = _date;
                stock_symbol = _stock_symbol;
                stock_price_open = _stock_price_open;
                stock_price_close = _stock_price_close;
                stock_price_low = _stock_price_low;
                stock_price_high = _stock_price_high;
                stock_price_adj_close = _stock_price_adj_close;
                stock_volume = _stock_volume;
                stock_exchange = _stock_exchange;

        }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }

        }

        // Add method
        public void Add(DateTime _date, 
                        string _stock_symbol, 
                        decimal _stock_price_open, 
                        decimal _stock_price_close, 
                        decimal _stock_price_low, 
                        decimal _stock_price_high,
                        decimal _stock_price_adj_close,
                        int _stock_volume,
                        string _stock_exchange
                        )
        {
            // add properties to object

            try
            {

                date = _date;
                stock_symbol = _stock_symbol;
                stock_price_open = _stock_price_open;
                stock_price_close = _stock_price_close;
                stock_price_low = _stock_price_low;
                stock_price_high = _stock_price_high;
                stock_price_adj_close = _stock_price_adj_close;
                stock_volume = _stock_volume;
                stock_exchange = _stock_exchange;

            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }

        }

    }
}
