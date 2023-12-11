//Declaring variables
const mongoose = require('mongoose');
const Joi = require('joi');

//Creating a schema for posts
const postSchema = new mongoose.Schema({
    id: String,
    subject: String,
    description: String,
    departmentCode: String,
});

const Post = mongoose.model('Post', postSchema);

//Creating standard validation length requirements for a post to be created
function ValidatePost(post) {
    const schema = Joi.object({
        id: Joi.string().min(1).max(50).required(),
        departmentCode: Joi.string().min(6).max(50).required(),
        subject: Joi.string().min(3).max(50).required(),
        description: Joi.string().min(3).max(1500).required(),
    });
    return schema.validate(post);
}

module.exports = { Post, ValidatePost };