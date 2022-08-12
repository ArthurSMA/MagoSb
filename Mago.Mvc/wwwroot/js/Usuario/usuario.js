var usuario = (function () {
    var configs = {
        urls: {
            cadastrar: '',
        }
    };

    var init = function ($configs) {
        configs = $configs;
    }

    var cadastrar = function () {
        moedl = $('#form-cadastrar').serializeObject();

        if (moedl == null) {
            site.toast.error("Nenhum dado foi informado!");
            return;
        }

        $.post(configs.urls.cadastrar, model).done(function () {
            site.toast.sucess("Usuario cadastrado com sucesso!");
            document.getElementById("")
            document.getElementById("")
        }).fail(function (msg) {
            site.toast.error(msg)
        })
    }

    return {
        init: init,
        cadastrar: cadastrar
    };
})()
