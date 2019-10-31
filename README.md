# bensley
A creative concept piece intended for bensley.com. Client requested an "infinite" way to explore his 300,000 image asset portfolio, his "world". To demonstrate the concept, we built an MVP using Unity, and deployed it using webGL and our backend API meredith-core, to do image delivery. The globe is built using a random and dynamic assortment of the image library, which change as days are clicked. If brought live, heavy optimizations would need to be done, as well as a re-factor to allow better lighting changes to the entire site, not just the globe.

Built as a portfolio to display large amount of images/videos in an interactive fashion. Benley.com is a concept site which creates an interactive mosiac using the content from a users portfolio. Clicking on different menu items cycle the globe and content, showing a new category of content. This project is still in beta, and is not supported across all browsers or platforms.

# how-to
Unity project files are still being built and will be deployed to a repo once we finish.  
Upload your portfolio images to cloudinary.com and tag them with the relevant tags per category (monday, tuesday, etc). We intend to build more flexible tagging functionality at some point.  
Auth through meredith-core  
launch? (will update)

## Preview URL
[![Netlify Status](https://api.netlify.com/api/v1/badges/0329703a-a606-4a04-9005-359d389a2e3e/deploy-status)](https://app.netlify.com/sites/hardcore-swartz-cf36a4/deploys)

Demo: https://hardcore-swartz-cf36a4.netlify.com/

## Design File:

https://www.figma.com/file/SIKQhrHGcCUaaJVI014bKORb/Bensley?node-id=173%3A292

## Frontend:
Vue with typescript and Bootstrap
Along with Vuex for state management

## Backend:
Managed by meredith-core api https://github.com/whynotearth/meredith-core

## Tools

[<img src="https://raw.githubusercontent.com/whynotearth/shinta-mani-wild/master/src/assets/img/browserstack-logo.png">](https://browserstack.com)

## We'd love your help making WHY NOT EARTH better

There are a lot of ways you can contribute to making WHY NOT EARTH better! You can report bugs and feature requests or ideally become an ongoing participant in the WHY NOT EARTH Project community and contribute code to the open source project.

We enthusiastically welcome new contributors to the WHY NOT EARTH Projects **_even if you have no experience being part of an open source project_**.  

If you're new to **contributing to the WHY NOT EARTH open source project**, sign up for our [Discord](https://discord.gg/EBpyFM3) and say Hi! Check out our [wiki](https://github.com/whynotearth/whynot.earth/wiki) for more info about our team and what we do!

## License

bensley is licensed under the [Apache License, Version 2.0](LICENSE).

