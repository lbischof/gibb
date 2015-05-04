<?php namespace App\Http\Middleware;

class Authentication {

    /**
     * Run the request filter.
     *
     * @param  \Illuminate\Http\Request  $request
     * @param  \Closure  $next
     * @return mixed
     */
    public function handle($request, $next)
    {
        if (!\Auth::check()) {
            return redirect('login');
        }

        return $next($request);
    }

}