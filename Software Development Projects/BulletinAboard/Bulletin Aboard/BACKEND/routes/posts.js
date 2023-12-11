//Declaring variables
const router = require('express').Router();
const auth = require('../middleware/auth');
const { Post, ValidatePost } = require('../models/post');

//Get all Posts
router.get('/', auth, async (req, res) => {
    const posts = await Post.find();
    res.status(201).json({
        message: "Posts found...",
        post: posts
    });
});

//Create a new post
router.post('/', auth, async (req, res) => {
    const { error } = ValidatePost(req.body);
    if (error) return res.status(400).json(error.details[0].message)

    const post = new Post(req.body);
    post.save();
    res.status(201).json({
        message: "Your post has been created!",
        post: post
    });
});

//Get a single post
router.get('/:id', auth, async (req, res) => {
    const post = await Post.findById(req.params.id);
    if (post) return res.send(post);
    res.status(201).json({
        message: "Post found!",
        post: post
    });
});

//Delete a single post
router.delete('/:id', auth, async (req, res) => {
    const result = await Post.deleteOne({ _id: req.params.id });
    res.status(201).json({
        message: "Post deleted!",
        result: result
    });
});

module.exports = router;