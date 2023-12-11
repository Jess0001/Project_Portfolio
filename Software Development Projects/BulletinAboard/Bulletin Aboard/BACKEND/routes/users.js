//Declaring variables
const router = require('express').Router();
const { User, ValidateUser } = require('../models/user');
const { hashPassword } = require('../utils/hash')
const auth = require('../middleware/auth');

//Create new User
router.post('/', async (req, res) => {
    const { error } = ValidateUser(req.body);
    if (error) return res.status(400).json(error.details[0].message);

    const isUnique = (await User.count({ username: req.body.username })) === 0;

    if (!isUnique)
        return res
            .status(400)
            .json({ error: 'The Username is invalid!' });

    try {
        const user = new User(req.body);
        user.password = await hashPassword(user.password);
        await user.save();
        res.status(201).json({
            message: "Creating user...",
            user: user
        });
    } catch (err) {
        return res.status(500).json(err);
    }
});

//Call login route
router.get('/', auth, async (req, res) => {
    res.send({ currentUser: req.user });
});

module.exports = router;