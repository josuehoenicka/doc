document.addEventListener('DOMContentLoaded', function() {
    const tipoSeguro = document.getElementById('tipoSeguro');
    const precioSeguro = document.getElementById('precioSeguro');

    tipoSeguro.addEventListener('change', function() {
        const selectedOption = tipoSeguro.value;
        let price = '';
        switch (selectedOption) {
            case 'basico':
                price = '$500';
                break;
            case 'intermedio':
                price = '$1000';
                break;
            case 'premium':
                price = '$1500';
                break;
            default:
                price = 'Seleccione un tipo de seguro';
        }
        precioSeguro.textContent = price;
    });
});
