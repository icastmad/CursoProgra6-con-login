
const VueLoaderTemplateAsync = async (Url: string): Promise<{ WatchRender: VueDecorator, WatchExtendedVue: ExtendedVue<Vue, {}, {}, {}, {}> }> => {
    try {
        const { data } = await CoreFile.GetStringAsync(Url);
        var VueLoaderTemplate = {
            WatchRender: VueClassComponent.createDecorator((opt, key) => {
                var { compileToFunctions } = VueTemplateCompiler;
                var renderFn = compileToFunctions(data);
                opt.render = renderFn.render;
                opt.staticRenderFns = renderFn.staticRenderFns;

            }),
            WatchExtendedVue: Vue.extend({ template: data })
        };
        return VueLoaderTemplate;

    } catch (e) {
        console.log(e, 'Error');
        return {
            WatchRender: VueClassComponent.createDecorator((opt, key) => { }),
            WatchExtendedVue: Vue.extend()
        };

    }
}


const VueLoaderTemplate = (url: string) => {
    try {
        var ajax = new XMLHttpRequest();
        ajax.open("GET", `${url}`, false)
        ajax.setRequestHeader("Content-Type", "text/plain;charset=UTF-8");
        ajax.setRequestHeader("Cache-Control", "no-cache,no-store");
        ajax.send();
        if (ajax.status === 200) {
            var VueLoaderTemplate = {
                WatchRender: VueClassComponent.createDecorator((opt, key) => {
                    var { compileToFunctions } = VueTemplateCompiler;
                    var renderFn = compileToFunctions(ajax.responseText);
                    opt.render = renderFn.render;
                    opt.staticRenderFns = renderFn.staticRenderFns;
                }),
                WatchExtendedVue: Vue.extend({ template: ajax.responseText })
            };
            return VueLoaderTemplate;
        } else {
            console.log(ajax.statusText, 'Error');
            return {
                WatchRender: VueClassComponent.createDecorator((opt, key) => { }),
                WatchExtendedVue: Vue.extend()
            };
        }

    } catch (e) {
        console.log(e, 'error');
        return {
            WatchRender: VueClassComponent.createDecorator((opt, key) => { }),
            WatchExtendedVue: Vue.extend()
        };
    }

};