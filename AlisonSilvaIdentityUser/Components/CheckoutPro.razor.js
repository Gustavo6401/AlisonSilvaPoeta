const mp = new MercadoPago('TEST-4633e0fb-bc0c-4183-b49a-93b550783a52');
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
