using Alt.Utils;
using Alt.Utils.Generics;
using Dominio.Localidades.PlusCode;
using Google.OpenLocationCode;
using System;

namespace PlusCode
{
    public class PlusCodeBuilder : IPlusCodeBuilder
    {
        public IMaybe<IPlusCode> Builder(string code, int codeLengt = 10)
        {
            if (OpenLocationCode.IsValidCode(code))
            {
                var co = OpenLocationCode.Decode(code);
                return Maybe<IPlusCode>.Some(new Dominio.Localidades.PlusCode
                                                .PlusCode(code: code,
                                                            latitude: co.WestLongitude.ToString(),
                                                            longitude: co.SouthLatitude.ToString(),
                                                            codeL: 10));
            }
            return Maybe<IPlusCode>.WithError($"{code} não é um codigo valido.");
        }

        public IMaybe<IPlusCode> Builder(double longitude, double latitude, int codeLengt = 10)
        {
            var co = OpenLocationCode.Encode(latitude:latitude,longitude:longitude);
            return Maybe<IPlusCode>.Some(new Dominio.Localidades.PlusCode
                                            .PlusCode(code: co,
                                                        latitude: latitude.ToString(),
                                                        longitude: longitude.ToString(),
                                                        codeL: 10));
            
        }
    }
}
