var usuario = (function () {
    var configs = {
        urls: {
            login: '',
        }
    };

    var init = function ($configs) {
        configs = $configs;
    }

    var login = function () {
        moedl = $('#form-login').serializeObject();

        if (moedl == null) {
            site.toast.error("Nenhum dado foi informado!");
            return;
        }

        $.post(configs.urls.login, model).done(function () {
            site.toast.sucess("Usuario cadastrado com sucesso!");
        }).fail(function (msg) {
            site.toast.error(msg)
        })
    }

    return {
        init: init,
        login: login
    };
})()
