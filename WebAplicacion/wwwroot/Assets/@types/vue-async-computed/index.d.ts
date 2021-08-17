

 interface IAsyncComputedOptions {
    errorHandler?: (error: string | Error) => void;
    useRawError?: boolean;
    default?: any;
}

declare class AsyncComputed {
    constructor(options?: IAsyncComputedOptions);
    static install: PluginFunction<never>;
    static version: string;
}

 type AsyncComputedGetter<T> = () => Promise<T>;

 interface IAsyncComputedValue<T> {
    default?: T | (() => T);
    get?: AsyncComputedGetter<T>;
    watch?: string[] | (() => void);
    shouldUpdate?: () => boolean;
    lazy?: boolean;
}

 interface AsyncComputedObject {
    [K: string]: AsyncComputedGetter<any> | IAsyncComputedValue<any>;
}

 interface IASyncComputedState {
    state: 'updating' | 'success' | 'error';
    updating: boolean;
    success: boolean;
    error: boolean;
    exception: Error | null;
    update: () => void;
}


    interface ComponentOptions<V extends Vue> {
        asyncComputed?: AsyncComputedObject;
    }


    interface Vue {
        $asyncComputed: { [K: string]: IASyncComputedState };
    }

interface IAsyncComputedProp {
    <T>(computedOptions: IAsyncComputedValue<T>): VueDecorator
    (): VueDecorator;
}
declare var AsyncComputedProp: IAsyncComputedProp ;