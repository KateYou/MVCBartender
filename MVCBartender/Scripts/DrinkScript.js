// JavaScript source code
<script>
    document.getElementById("chooseItem").onmouseup = function ()
    {
        addItem()
    };
    function addItem() {
        var x = document.getElementById("chooseItem").value;
        document.getElementById("customerOrder").innerHTML = x;
    }
</script>