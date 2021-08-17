


interface IComponetObjectExtend {
    registerHooks: (keys: string[]) => void;
}


interface IComponetExtend extends IComponetObjectExtend {
    <V extends Vue>(options: ComponentOptions<V> & ThisType<V>): <VC extends VueClass<V>>(target: VC) => VC;
    <VC extends VueClass<Vue>>(target: VC): VC;
}



declare namespace VuePropertyDecorator {
    
    export var  Component: IComponetExtend;

    export function Mixins<A>(CtorA: VueClass<A>): VueClass<A>;
    export function Mixins<A, B>(CtorA: VueClass<A>, CtorB: VueClass<B>): VueClass<A & B>;
    export function Mixins<A, B, C>(CtorA: VueClass<A>, CtorB: VueClass<B>, CtorC: VueClass<C>): VueClass<A & B & C>;
    export function Mixins<A, B, C, D>(CtorA: VueClass<A>, CtorB: VueClass<B>, CtorC: VueClass<C>, CtorD: VueClass<D>): VueClass<A & B & C & D>;
    export function Mixins<A, B, C, D, E>(CtorA: VueClass<A>, CtorB: VueClass<B>, CtorC: VueClass<C>, CtorD: VueClass<D>, CtorE: VueClass<E>): VueClass<A & B & C & D & E>;
    export function Mixins<A, B, C, D, E, F>(CtorA: VueClass<A>, CtorB: VueClass<B>, CtorC: VueClass<C>, CtorD: VueClass<D>, CtorE: VueClass<E>, CtorF: VueClass<F>): VueClass<A & B & C & D & E & F>;
    export function Mixins<A1, A2, A3, A4, A5, A6, A7>(A1: VueClass<A1>, A2: VueClass<A2>, A3: VueClass<A3>, A4: VueClass<A4>, A5: VueClass<A5>, A6: VueClass<A6>, A7: VueClass<A7>): VueClass<A1 & A2 & A3 & A4 & A5 & A6 & A7>;
    export function Mixins<A1, A2, A3, A4, A5, A6, A7, A8>(A1: VueClass<A1>, A2: VueClass<A2>, A3: VueClass<A3>, A4: VueClass<A4>, A5: VueClass<A5>, A6: VueClass<A6>, A7: VueClass<A7>, A8: VueClass<A8>): VueClass<A1 & A2 & A3 & A4 & A5 & A6 & A7 & A8>;
    export function Mixins<A1, A2, A3, A4, A5, A6, A7, A8, A9>(A1: VueClass<A1>, A2: VueClass<A2>, A3: VueClass<A3>, A4: VueClass<A4>, A5: VueClass<A5>, A6: VueClass<A6>, A7: VueClass<A7>, A8: VueClass<A8>, A9: VueClass<A9>): VueClass<A1 & A2 & A3 & A4 & A5 & A6 & A7 & A8 & A9>;
    export function Mixins<A1, A2, A3, A4, A5, A6, A7, A8, A9, A10>(A1: VueClass<A1>, A2: VueClass<A2>, A3: VueClass<A3>, A4: VueClass<A4>, A5: VueClass<A5>, A6: VueClass<A6>, A7: VueClass<A7>, A8: VueClass<A8>, A9: VueClass<A9>, A10: VueClass<A10>): VueClass<A1 & A2 & A3 & A4 & A5 & A6 & A7 & A8 & A9 & A10>;
    export function Mixins<A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11>(A1: VueClass<A1>, A2: VueClass<A2>, A3: VueClass<A3>, A4: VueClass<A4>, A5: VueClass<A5>, A6: VueClass<A6>, A7: VueClass<A7>, A8: VueClass<A8>, A9: VueClass<A9>, A10: VueClass<A10>, A11: VueClass<A11>): VueClass<A1 & A2 & A3 & A4 & A5 & A6 & A7 & A8 & A9 & A10 & A11>;
    export function Mixins<A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12>(A1: VueClass<A1>, A2: VueClass<A2>, A3: VueClass<A3>, A4: VueClass<A4>, A5: VueClass<A5>, A6: VueClass<A6>, A7: VueClass<A7>, A8: VueClass<A8>, A9: VueClass<A9>, A10: VueClass<A10>, A11: VueClass<A11>, A12: VueClass<A12>): VueClass<A1 & A2 & A3 & A4 & A5 & A6 & A7 & A8 & A9 & A10 & A11 & A12>;
    export function Mixins<A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12, A13>(A1: VueClass<A1>, A2: VueClass<A2>, A3: VueClass<A3>, A4: VueClass<A4>, A5: VueClass<A5>, A6: VueClass<A6>, A7: VueClass<A7>, A8: VueClass<A8>, A9: VueClass<A9>, A10: VueClass<A10>, A11: VueClass<A11>, A12: VueClass<A12>, A13: VueClass<A13>): VueClass<A1 & A2 & A3 & A4 & A5 & A6 & A7 & A8 & A9 & A10 & A11 & A12 & A13>;
    export function Mixins<A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12, A13, A14>(A1: VueClass<A1>, A2: VueClass<A2>, A3: VueClass<A3>, A4: VueClass<A4>, A5: VueClass<A5>, A6: VueClass<A6>, A7: VueClass<A7>, A8: VueClass<A8>, A9: VueClass<A9>, A10: VueClass<A10>, A11: VueClass<A11>, A12: VueClass<A12>, A13: VueClass<A13>, A14: VueClass<A14>): VueClass<A1 & A2 & A3 & A4 & A5 & A6 & A7 & A8 & A9 & A10 & A11 & A12 & A14>;
    export function Mixins<T>(...Ctors: VueClass<Vue>[]): VueClass<T>;
/**
 * decorator of an inject
 * @param from key
 * @return PropertyDecorator
 */
    export function  Inject(options?: InjectOptions | InjectKey): VueDecorator;
/**
 * decorator of a reactive inject
 * @param from key
 * @return PropertyDecorator
 */
    export function   InjectReactive(options?: InjectOptions | InjectKey): VueDecorator;
/**
 * decorator of a provide
 * @param key key
 * @return PropertyDecorator | void
 */
    export function   Provide(key?: string | symbol):VueDecorator;
/**
 * decorator of a reactive provide
 * @param key key
 * @return PropertyDecorator | void
 */
    export function    ProvideReactive(key?: string | symbol): VueDecorator;
/**
 * decorator of model
 * @param  event event name
 * @param options options
 * @return PropertyDecorator
 */
    export function   Model(event?: string, options?: PropOptions | Constructor[] | Constructor): (target: Vue, key: string) => void;
/**
 * decorator of a prop
 * @param  options the options for the prop
 * @return PropertyDecorator | void
 */
    export function    Prop(options?: PropOptions | Constructor[] | Constructor): (target: Vue, key: string) => void;
/**
 * decorator of a synced prop
 * @param propName the name to interface with from outside, must be different from decorated property
 * @param options the options for the synced prop
 * @return PropertyDecorator | void
 */
    export function    PropSync(propName: string, options?: PropOptions | Constructor[] | Constructor): PropertyDecorator;
/**
 * decorator of a watch function
 * @param  path the path or the expression to observe
 * @param  WatchOption
 * @return MethodDecorator
 */
    export function   Watch(path: string, options?: WatchOptions):VueDecorator;
/**
 * decorator of an event-emitter function
 * @param  event The name of the event
 * @return MethodDecorator
 */
    export function   Emit(event?: string): (_target: Vue, propertyKey: string, descriptor: any) => void;
/**
 * decorator of a ref prop
 * @param refKey the ref key defined in template
 */
    export function   Ref(refKey?: string): VueDecorator;
}

interface IModuleVueComponent<V extends Vue = Vue, Data = object, Methods = object, Computed = object, Props = object> {
    exports: any ;

}



interface IhttpVueLoader {
    (Url: string): () => Promise<ExtendedVue<Vue, {}, {}, {}, {}>>;
    register(VueIntance: VueConstructor<Vue>, ulr: string)
}