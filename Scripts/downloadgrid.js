$(function () {

    $("#grid-container").dxDataGrid({
        dataSource: {
            store: productsStore,
            reshapeOnPush: true
        },
        repaintChangesOnly: true,
        columnAutoWidth: true,
        showBorders: true,
        paging: {
            pageSize: 10
        }
    });

    var updatesPerSecond = 100;

    setInterval(function () {


        for (var i = 0; i < 100 / 20; i++) {
         
                    addOrder();
           
        }
    }, 60000);

    $("#frequency-slider").dxSlider({
        min: 10,
        max: 5000,
        step: 10,
        value: updatesPerSecond,
        onValueChanged: function (e) {
            updatesPerSecond = e.value;
        },
        tooltip: {
            enabled: true,
            showMode: "always",
            format: "#0 per second",
            position: "top"
        }
    });
});