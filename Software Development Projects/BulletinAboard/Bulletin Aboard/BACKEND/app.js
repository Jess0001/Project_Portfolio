//Declare variables
require('dotenv').config();
const express = require('express');
const app = express();
const https = require('https');
const fs = require('fs');
const helmet = require('helmet');
const cors = require('cors');
const hsts = require('./middleware/hsts');
const mongoose = require('mongoose');

//Connect to database
mongoose
    .connect(process.env.MONGODB_URL)
    .then(() => console.log('Connected:-)'));

//Declare middleWare
app.use(helmet());
app.use(cors({ origin: 'https//localhost:7899', optionsSuccessStatus: 200 }));
app.use(express.json());
app.use(hsts);

//Declare routes
app.use('/api/auth', require('./routes/auth'));
app.use('/api/users', require('./routes/users'));
app.use('/api/posts', require('./routes/posts'));

const options =

    //Listen to server
    https
        .createServer(
            {
                key: fs.readFileSync('./keys/privatekey.pem'),
                cert: fs.readFileSync('./keys/certificate.pem'),
                passphrase: 'passphrase',
            },
            app
        )
        .listen(7899);