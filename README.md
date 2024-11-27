## Pixdata Mapbit API and architecture

- API encodes/decodes text to/from a image of single color
- Encoding is readable using any image editor.
- Encode/Decode is done by PixMapper class library



## Mapbit API Documentation

### Decode text from a single color image
Extract string from already encoded bitmap

`GET https://pixdata.com/api/v1/decode`


### Create encoded Bitmap with text
Creates bitmap with text encoded inside

`POST https://pixdata.com/api/v1/encode`

```
{
  text,
  filename,
  height,
  width,
  color
}
```


---


![Architecture](./images/MapBitArchitecture.png)

Reference links:
---------------------------------
[CQRS MediatR in Core](https://code-maze.com/cqrs-mediatr-in-aspnet-core/)

[CQRS](https://learn.microsoft.com/en-us/previous-versions/msp-n-p/jj591573(v=pandp.10)?redirectedfrom=MSDN)

[MediatR in C#](https://medium.com/codenx/implement-mediator-pattern-with-mediatr-in-c-8a271d7b9901)

[Use static files, perhaps store bitmaps like this?](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/static-files?view=aspnetcore-9.0)

[Create Class Library](https://learn.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio?pivots=dotnet-9-0)

