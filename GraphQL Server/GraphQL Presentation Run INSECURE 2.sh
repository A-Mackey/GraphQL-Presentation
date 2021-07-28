#!/bin/bash
(
cd '/Users/aidan.mackeyinrix.com/Documents/GitHub/GraphQL-Presentation/GraphQL Server'
echo `pwd`
NODE_TLS_REJECT_UNAUTHORIZED="0" npm run start
)