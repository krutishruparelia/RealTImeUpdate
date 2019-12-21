var products = [];
for (var i = 1; i <= 2000; i++) {

    products.push({ ID: i, FileName: dhistory[i].FileName, Msg: dhistory[i].Msg , Date: dhistory[i].Msg});
}

var productsStore = new DevExpress.data.ArrayStore({
    key: "ID",
    data: products
});
function addOrder() {
  
            productsStore.push([{
                type: "update",
                key: products.ID,
                data: {
                    ID: products.ID,
                    FileName: products.FileName,
                    Msg: products.Msg
                }
            }]);  
}