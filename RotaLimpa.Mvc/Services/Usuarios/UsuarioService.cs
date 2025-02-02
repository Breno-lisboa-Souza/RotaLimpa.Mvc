﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RotaLimpa.Mvc.Models;

namespace RotaLimpa.Mvc.Services.Usuarios
{
    public class UsuarioService : Request
    {
        private readonly Request _request;
        private const string apiUrlBase = "https://bsite.net/luizfernando987/Usuarios";
        //xyz --> Site da sua API

        public UsuarioService()
        {
            _request = new Request();
        }

        public async Task<Usuario> PostRegistrarUsuarioAsync(Usuario u)
        {
            //Registrar: Rota para o método na API que registrar o usuário
            string urlComplementar = "/Registrar";
            u.Id = await _request.PostReturnIntAsync(apiUrlBase + urlComplementar, u);
            return u;
        }
        public async Task<Usuario> PostAutenticarUsuarioAsync(Usuario u)
        {
            //Autenticar: Rota para o método na API que autentica com login e senha
            string urlComplementar = "/Autenticar";
            u = await _request.PostAsync(apiUrlBase + urlComplementar, u, string.Empty);
            return u;
        }
    }
}
