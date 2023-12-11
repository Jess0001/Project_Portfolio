//Declare variables
const bcrypt = require('bcrypt');

//Hash password using bcrypt and salt
async function hashPassword(password) {
    const salt = await bcrypt.genSalt(10);
    const hashed = await bcrypt.hash(password, salt);
    return hashed;
}

//Compare password and hash using bcrypt
async function isValidPassword(password, hash) {
    return await bcrypt.compare(password, hash);
}

module.exports = { hashPassword, isValidPassword };
