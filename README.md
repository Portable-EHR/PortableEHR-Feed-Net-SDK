# Portable EHR .Net Feed SDK

If you want to integrate your project to Portable EHR, then you can use our .Net SDK to jump start the integration.
This project provides the model POCOs, request and response objects in a .Net Core flavor. If you use others frameworks in your project, we hope you can use this code as an inspiration.

To see how to use this SDK you can check the demo project [Portable EHR .Net Feed Demo](https://github.com/Portable-EHR/PortableEHR-Net-Feed-Demo).

# Integrating with Portable EHR FeedHub
To integrate with Portable EHR FeedHub, your project must:
- Implement the [Feed API](https://feed.portableehr.io:4004/docs). FeedHub will consume this API once is correctly configured.
- Consume the [FeedHub API](https://feed.portableehr.io:3004/docs).

# Installing this NuGet package in your project
```xml
<ItemGroup>
  ...
  <PackageReference Include="PortableEHR.Feed.SDK" Version="1.0.0" />
</ItemGroup>
```

# SDK's structure
This SDK is divided in 3 main namespaces: *PortableEHRNetSDK.Model*, *PortableEHRNetSDK.Network* and *PortableEHRNetSDK.Converter*.
*PortableEHRNetSDK.Model* and *PortableEHRNetSDK.Network* namespaces contain in their root common classes and subnamespaces *Client* and *Server* with specifics classes for each API.
*PortableEHRNetSDK.Converter* contains converters that extend from System.Text.Json.JsonConverter to deal with the non trivial serializations and deserializations.

### PortableEHRNetSDK.Model
In this namespace you have the model entities

### PortableEHRNetSDK.Network
In this namespace you have mostly POCOs, and some  where needed:
- PortableEHRNetSDK.Network: Containing common network entities
- PortableEHRNetSDK.Network.Client.Request.[endpoint]: All the entities needed to send the requests your Feed will send to FeedHub
- PortableEHRNetSDK.Network.Client.Response.[endpoint]: All the entities needed to map the FeedHub responses to objects
- PortableEHRNetSDK.Network.Server.Request.[endpoint]: All the entities needed to map the FeedHub requests to objects
- PortableEHRNetSDK.Network.Server.Response.[endpoint]: All the entities needed to send the responses your Feed will send to FeedHub
