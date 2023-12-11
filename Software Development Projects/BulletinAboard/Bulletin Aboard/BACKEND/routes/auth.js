//Declare variables
const router = require('express').Router();
const jwt = require('jsonwebtoken');
const { User } = require('../models/user');
const { isValidPassword } = require('../utils/hash');
const ExpressBrute = require('express-brute');
const store = new ExpressBrute.MemoryStore();
const bruteforce = new ExpressBrute(store);

//Create login route
router.post('/', bruteforce.prevent, async (req, res) => {
    const user = await User.findOne({ username: req.body.username });
    if (!user)
        return res.status(401).json({ error: 'Invalid Credentials... Try again!' })

    const valid = await isValidPassword(req.body.password, user.password);

    if (!valid)
        return res.status(401).json({ error: 'Invalid Credentials... Try again!' });
    try {
        const token = jwt.sign({ userId: user._id }, process.env.JWT_KEY);
        res.status(201).json({
            message: "Logging in... Generating token... ",
            token: token
        });
    } catch (err) {
        return res.status(500).json(err);
    }

});

module.exports = router;