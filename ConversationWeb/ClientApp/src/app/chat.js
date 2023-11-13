// Fetch key, secret and ids from .env file
const accountSid = process.env.TWILIO_ACCOUNT_SID;
const authToken = process.env.TWILIO_AUTH_TOKEN;
const serviceSid = process.env.TWILIO_SERVICE_SID;
const apiKey = process.env.TWILIO_API_KEY;
const apiSecret = process.env.TWILIO_API_SECRET;
const client = require('twilio')(accountSid, authToken);

// Function to Create a new channel

// client.conversations.v1.conversations
//     .create({ friendlyName: 'My First Conversation' })
//     .then(conversation => console.log(conversation.sid, conversation));


//Fetch created channel

// client.conversations.v1.conversations('CH...')
//     .fetch()
//     .then(conversation => console.log(conversation.chatServiceSid));


// Enable reachability indicator

// client.conversations.v1.services(serviceSid)
//   .configuration()
//   .update({
//     reachabilityEnabled: true
//    }).then(configuration => console.log(configuration));


// Create a twilio access token to initialize SDK Client

function getToken(identity) {
    const AccessToken = require('twilio').jwt.AccessToken;
    const ChatGrant = AccessToken.ChatGrant;

    const chatGrant = new ChatGrant({
        serviceSid: serviceSid,
    });
    const token = new AccessToken(
        accountSid,
        apiKey,
        apiSecret,
        {
            identity: identity, // identify user uniquely
            ttl: 3600 // token expiration time
        }
    );

    token.addGrant(chatGrant);
    return token.toJwt();
}

module.exports = {getToken};
