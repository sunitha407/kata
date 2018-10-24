
$(document).ready(function () {
        
   
    function ConvertNumberToCurrencyFormat(data) {
        return data.toLocaleString('en-US', { style: 'currency', currency: 'USD' })
    }
    $("#btnCalculateCharges").click(function () {
        
        var BabySitterCalculatorServiceModel = {
            StartTime: $("#selectedStartTime").val(),
            EndTime: $("#selectedEndTime").val(),
            BillingCharges: "",
            BillingHours: ""
        };       
        
         $.ajax({
            type: "Post",
            url: 'api/BillingCalculator',
            contentType: 'application/json',
            cache: false,
            data: JSON.stringify(BabySitterCalculatorServiceModel),
            dataType: "json",
            success: function (result) {
               $("#BillingHours").text(result.BillingHours);
               $("#BillingCharge").text(ConvertNumberToCurrencyFormat(result.BillingCharge));
            },
            error: function(xhr, status, error){               
                alert(error.toString);
            }
           
        });
    });

    $("#selectedStartTime").change(function () {
        $("#selectedEndTime").val($("#selectedEndTime option:first").val());       
    });

    $("#selectedEndTime").change(function () {      
        if ($("#selectedStartTime").val().toString() == $("#selectedEndTime").val().toString())
            $("#selectedEndTime").val($("#selectedEndTime option:first").val());
    });
        
    
});