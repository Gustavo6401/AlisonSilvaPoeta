const mp = new MercadoPago('Minha Public Key');
const bricksBuilder = mp.bricks();

/**
 * 
 * @returns {string}
 */
function getPreferenceId() {
    var preferenceId = document.getElementById('preference-id').value

    return preferenceId
}

mp.bricks().create("wallet", "wallet_container", {
    initialization: {
        preferenceId: getPreferenceId(),
    },
    customization: {
        texts: {
            valueProp: 'smart_option',
        }
    }})
